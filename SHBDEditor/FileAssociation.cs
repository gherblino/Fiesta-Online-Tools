using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace SHBDEditor
{
	class FileAssociation
	{
		private static void AssociationInformation(String Ext, String ProgID, String ContentType, String Description)
		{
			Registry.ClassesRoot.CreateSubKey(Ext, RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("", ProgID);
			Registry.ClassesRoot.CreateSubKey(Ext, RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("Content Type", ContentType);
			Registry.ClassesRoot.CreateSubKey(ProgID + "\\shell\\open\\command").SetValue("", Application.ExecutablePath + " \"%1\"", RegistryValueKind.String);
			Registry.ClassesRoot.CreateSubKey(ProgID, RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("", Description, RegistryValueKind.String);
			Registry.ClassesRoot.CreateSubKey(ProgID + "\\DefaultIcon").SetValue("", Application.ExecutablePath, RegistryValueKind.String);
		}

		public static String AssociationCreation(String Ext, String ProgID, String ContentType, String[] OpenWithList = null, Boolean DeleteOldCreateNew = true, String Description = "No descrption")
		{
			String creationString = "null";

			try
			{
				Registry.ClassesRoot.OpenSubKey(Ext);
				if (DeleteOldCreateNew == true)
				{
					try { Registry.ClassesRoot.DeleteSubKeyTree(Ext, false); }
					catch (Exception) { }

					if (Ext == null || ProgID == null || ContentType == null)
					{
						if (Ext == null) { return creationString = "Please check extension."; }
						else if (ProgID == null) { return creationString = "Please check program ID."; }
						else if (ContentType == null) { return creationString = "Please check content type."; }
						else { return creationString = "An unknown error occured."; }
					}
					else
					{
						if (OpenWithList == null)
						{
							AssociationInformation(Ext, ProgID, ContentType, Description);
							return creationString = "Association with " + Ext + " files have been created successfully without an open list.";
						}
						else
						{
							foreach (string Prog in OpenWithList)
							{
								Registry.ClassesRoot.CreateSubKey(Ext + "\\OpenWithList\\" + Prog, RegistryKeyPermissionCheck.ReadWriteSubTree);
							}
							AssociationInformation(Ext, ProgID, ContentType, Description);
							return creationString = "Association with " + Ext + " files have been created successfully with the appropriate open list.";
						}
					}
				}
				return creationString = "A sub key already exsists for this file extension.";
			}
			catch (NullReferenceException)
			{
				if (Ext == null || ProgID == null || ContentType == null)
				{
					if (Ext == null) { return creationString = "Please check extension."; }
					else if (ProgID == null) { return creationString = "Please check program ID."; }
					else if (ContentType == null) { return creationString = "Please check content type."; }
					else { return creationString = "An unknown error occured."; }
				}
				else
				{
					if (OpenWithList == null)
					{
						AssociationInformation(Ext, ProgID, ContentType, Description);
						return creationString = "Association with " + Ext + " files have been created successfully without an open list.";
					}
					else
					{
						foreach (string Prog in OpenWithList)
						{
							Registry.ClassesRoot.CreateSubKey(Ext + "\\OpenWithList\\" + Prog, RegistryKeyPermissionCheck.ReadWriteSubTree);
						}
						AssociationInformation(Ext, ProgID, ContentType, Description);
						return creationString = "Association with " + Ext + " files have been created successfully with the appropriate open list.";
					}
				}
			}
			catch (Exception ex)
			{
				return creationString = "An unknown error occured: " + ex.Message;
			}
		}

		public static void AssociationDeletion(String Ext, String ProgID)
		{
			try
			{
				Registry.ClassesRoot.DeleteSubKeyTree(Ext, false);
				Registry.ClassesRoot.DeleteSubKeyTree(ProgID, false);
				Registry.CurrentUser.DeleteSubKeyTree("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\" + Ext, false);
			}
			catch (Exception) { }
		}

		public static Boolean AssociationCheck(String Ext, String ProgID)
		{
			try
			{
				Registry.ClassesRoot.OpenSubKey(Ext);
				if (Registry.ClassesRoot.OpenSubKey(Ext).GetValue("").ToString() != ProgID) return false;
				return true;
			}
			catch (NullReferenceException)
			{
				return false;
			}
		}
	}
}
