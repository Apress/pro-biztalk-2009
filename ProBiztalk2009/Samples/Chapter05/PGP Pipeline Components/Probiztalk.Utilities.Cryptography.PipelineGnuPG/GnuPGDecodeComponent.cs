using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using Microsoft.BizTalk.Component.Interop;
using Probiztalk.Utilities.Cryptography.GnuPG;

namespace Probiztalk.Samples.PipelineComponents
{
	[ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
	[ComponentCategory(CategoryTypes.CATID_Decoder)]
	[System.Runtime.InteropServices.Guid("AEE2E180-8E4F-426d-9E39-C314E09F977E")]
    public class GnuPGDecodeComponent :
		IBaseComponent,
		Microsoft.BizTalk.Component.Interop.IComponent,
		Microsoft.BizTalk.Component.Interop.IPersistPropertyBag,
		IComponentUI
	{

		// Component information
		#region IBaseComponent
		[Browsable(false)] 
        public string Name 
        { 
            get 
            { 
                return "Gnu PGP decoder"; 
            } 
        }
		[Browsable(false)] 
        public string Version 
        { 
            get 
            { 
                return "1.0"; 
            } 
        }
		[Browsable(false)] 
        public string Description 
        { 
            get 
            { 
                return "GnuPG Decode Pipeline Component"; 
            } 
        }
		[Browsable(false)] 
        public System.IntPtr Icon	
        { 
            get 
            { 
                return ((Bitmap)resourceManager.GetObject("IconBitmap")).
                                        GetHicon(); 
            } 
        }
		#endregion

		private System.Resources.ResourceManager resourceManager =
			new System.Resources.ResourceManager(
                    "Probiztalk.Samples.PipelineComponents.GnuPGDecodeComponent", 
                    Assembly.GetExecutingAssembly());

		// Property: Passphrase
		private string _passphrase;
		[
		DisplayName("Passphrase"),
		Description("Passphrase used to retreive private key.")
		]
		public string Passphrase
		{
			get {  return _passphrase; }
			set {  _passphrase = value; }
		}

		// Property: GnuPGBinDir
		private string _gnupgbindir;
		[
		DisplayName("GnuPGBinDir"),
		Description(@"Installation directory of GnuPG, that contains gpg.exe file.
                        Default, if not specified, is ""C:\gnupg"". 
                        Do not include trailing slash.")
		]
		public string GnuPGBinDir
		{
			get {  return _gnupgbindir; }
			set {  _gnupgbindir = value; }
		}

		private Stream Decode (System.IO.Stream inStream)
		{
			Stream outStream = inStream;
			string inFile = Path.GetTempFileName();
			string outFile = Path.ChangeExtension(inFile, "txt");

			try 
			{
				DumpStreamToFile( inStream, inFile );

				GnuPGWrapper GPG = new GnuPGWrapper(_gnupgbindir);
				GnuPGCommand GPGCommand = GPG.Command;
				GPGCommand.Command = Commands.Decrypt;
				GPGCommand.InputFile = inFile;
				GPGCommand.OutputFile = outFile;
				GPGCommand.Passphrase = _passphrase;
				// TODO: support encrypted passphrase, 
                //no passphrase is a security risk
				
				GPG.Execute(null);
					
				outStream = ReadFileToMemoryStream( outFile );
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex);
			}
			finally
			{
				if (File.Exists(inFile))
				{
					File.Delete(inFile);
				}

				if (File.Exists(outFile))
				{
					File.Delete(outFile);
				}
			}

			return outStream;
		}

		#region IPersistPropertyBag Members

		public void InitNew()
		{
		}

		public void GetClassID(out Guid classID)
		{
			classID = new Guid ("4FC12033-D0BD-4298-BB31-FBDBA72F5961");
		}

		public void Load(IPropertyBag propertyBag, int errorLog)
		{
			string text;
			text = (string)ReadPropertyBag( propertyBag, "Passphrase" );
			if (text != null) _passphrase = text;
			text = (string)ReadPropertyBag( propertyBag, "GnuPGBinDir" );
			if (text != null) _gnupgbindir = text;
		}

		public void Save(IPropertyBag propertyBag, bool clearDirty, 
                        bool saveAllProperties)
		{
			object val;
			val = (object)_passphrase;
			WritePropertyBag( propertyBag, "Passphrase", val );
			val = (object)_gnupgbindir;
			WritePropertyBag( propertyBag, "GnuPGBinDir", val );
		}

		#endregion
	
	
		#region IComponent Members

		public Microsoft.BizTalk.Message.Interop.IBaseMessage
            Execute(IPipelineContext pContext, 
            Microsoft.BizTalk.Message.Interop.IBaseMessage pInMsg)
		{
			try
			{
				if (pInMsg != null)
				{
					Stream originalStream = pInMsg.BodyPart.
                                            GetOriginalDataStream();
					pInMsg.BodyPart.Data = Decode( originalStream );
					pContext.ResourceTracker.AddResource( pInMsg.BodyPart.Data );
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine( 
                    @"Exception caught in GnuPGDecodeComponent::Execute: " 
                    + ex.Message );
			}
			return pInMsg;
		}

		#endregion

		#region IComponentUI Members

		/// <summary>
		/// The Validate method is called by the BizTalk Editor during the build 
		/// of a BizTalk project.
		/// </summary>
		/// <param name="obj">An Object containing 
        /// the configuration properties.</param>
		/// <returns>The IEnumerator enables the caller to enumerate through a
        /// collection of strings containing error messages. These error messages
        /// appear as compiler error messages. 
        /// To report successful property validation,
        /// the method should return an empty enumerator.</returns>
		public IEnumerator Validate(object projectSystem)
		{
			// example implementation:
			// ArrayList errorList = new ArrayList();
			// errorList.Add("This is a compiler error");
			// return errorList.GetEnumerator();
			return null;
		}
        

		#endregion

        #region Utility Functions

        public static void DumpStreamToFile(Stream fromStream, string toFilename)
        {
            FileStream file = null;
            try
            {
                file = new FileStream(toFilename, System.IO.FileMode.Create);
                byte[] tmpBuff = new byte[4096];
                int bytesRead = 0;

                while ((bytesRead =
                        fromStream.Read(tmpBuff, 0, tmpBuff.Length)) != 0)
                {
                    file.Write(tmpBuff, 0, bytesRead);
                }

                file.Close();
                file = null;
            }
            finally
            {
                if (file != null) file.Close();
            }
        }

        public static MemoryStream ReadFileToMemoryStream(string fromFilename)
        {
            FileStream file = null;
            try
            {
                file = new FileStream(fromFilename, System.IO.FileMode.Open);
                MemoryStream memStream = new MemoryStream();
                byte[] tmpBuff = new byte[4096];
                int bytesRead = 0;

                while ((bytesRead = file.Read(tmpBuff, 0, tmpBuff.Length)) != 0)
                {
                    memStream.Write(tmpBuff, 0, bytesRead);
                }

                file.Close();
                file = null;

                memStream.Position = 0;
                return memStream;
            }
            finally
            {
                if (file != null) file.Close();
            }
        }
        /// <summary>
        /// Reads property value from property bag.
        /// </summary>
        /// <param name="pb">Property bag.</param>
        /// <param name="propName">Name of property.</param>
        /// <returns>Value of the property.</returns>
        public static object
            ReadPropertyBag(Microsoft.BizTalk.Component.Interop.IPropertyBag pb,
                            string propName)
        {
            object val = null;

            try
            {
                pb.Read(propName, out val, 0);
            }
            catch (ArgumentException)
            {
                return val;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

            return val;
        }

        /// <summary>
        /// Writes property values into a property bag.
        /// </summary>
        /// <param name="pb">Property bag.</param>
        /// <param name="propName">Name of property.</param>
        /// <param name="val">Value of property.</param>
        public static void WritePropertyBag(
                            Microsoft.BizTalk.Component.Interop.IPropertyBag pb,
                            string propName, object val)
        {
            try
            {
                pb.Write(propName, ref val);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }


        #endregion
    }
}
