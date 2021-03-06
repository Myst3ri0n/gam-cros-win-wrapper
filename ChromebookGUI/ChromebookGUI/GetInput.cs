﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromebookGUI
{
    /// <summary>
    /// A class for getting input. Contains methods for a text input, deprovision reason input and a DataGrid input.
    /// </summary>
    class GetInput
    {
        /// <summary>
        /// Allows you to get text input via a dialog.
        /// Your button, if clicked, will return "ExtraButtonClicked".
        /// </summary>
        /// <param name="instructionText">The top header text block shown to the user.</param>
        /// <param name="inputBoxPrefill">What will be prefilled in the input box.</param>
        /// <param name="title">The title of the window.</param>
        /// <returns></returns>
        public static string getInput(String instructionText, String inputBoxPrefill, String title, Button button)
        {
            InputWindow inputWindow = new InputWindow();
            inputWindow.instructionTextBlock.Text = instructionText;
            inputWindow.inputBox.Text = inputBoxPrefill;
            inputWindow.inputBox.SelectionStart = 0;
            inputWindow.inputBox.SelectionLength = inputBoxPrefill.Length;
            if (button.IsEnabled == false) {
                inputWindow.ExtraButton.Opacity = 0;
                inputWindow.ExtraButton.IsEnabled = false;
            } else
            {
                inputWindow.ExtraButton.Content = button.Text;
            }
            inputWindow.Title = title;
            inputWindow.ShowDialog();
            inputWindow.Activate();
            if (inputWindow.inputBox.Text == inputBoxPrefill || inputWindow.inputBox.Text.Length < 1)
            {
                return null;
            } else
            {
                return inputWindow.inputBox.Text;
            }
        }

        public static string getInput(String instructionText, String inputBoxPrefill, String title)
        {
            return getInput(instructionText, inputBoxPrefill, title, new Button { IsEnabled = false });
        }
        /// <summary>
        /// Only has instructionText. Sets inputBoxPrefill to "Enter value here...", and sets the window title to "InputWindow".
        /// </summary>
        /// <param name="instructionText"></param>
        /// <returns></returns>
        public static string getInput(String instructionText)
        {
            return getInput(instructionText, "Enter value here...", "InputWindow");
        }

        /// <summary>
        /// GetInput.getInput, but without the window title param. Sets it to "InputWindow".
        /// </summary>
        /// <param name="instructionText"></param>
        /// <param name="inputBoxPrefill"></param>
        /// <returns></returns>
        public static string getInput(String instructionText, String inputBoxPrefill)
        {
            return getInput(instructionText, inputBoxPrefill, "InputWindow");
        }



        /// <summary>
        /// A method for getting the deprovision reason for a deprovision action.
        /// </summary>
        /// <returns></returns>
        public static int GetDeprovisionReason()
        {
            DeprovisionSelect window = new DeprovisionSelect();
            window.Title = "Deprovision Reason";
            window.ShowDialog();
            window.Activate();

            // window has closed
            if (window.sameModelReplacementRadio.IsChecked == true)
            {
                return 1;
            }
            else if (window.differentModelReplacementRadio.IsChecked == true)
            {
                return 2;
            } else if (window.retiringDeviceRadio.IsChecked == true)
            {
                return 3;
            } else
            {
                return 0;
            }
        }
        /// <summary>
        /// Gets a DataGrid input. When the user clicks on a row in the DataGrid, you get that row, back as a List<string>.
        /// </summary>
        /// <param name="instructionText">The header text at the top of the window.</param>
        /// <param name="instructionTextBoxText">The text that will go in the optional manual input box.</param>
        /// <param name="title">The window title.</param>
        /// <param name="inputData">An object containing data for the DataTable.</param>
        /// <returns></returns>
        public static List<string> GetDataGridSelection(String instructionText, String instructionTextBoxText, String title, List<OrgUnit> inputData)
        {
            DataGridInput inputWindow = new DataGridInput();
            inputWindow.instructionTextBlock.Text = instructionText;
            inputWindow.radioGrid.ItemsSource = inputData;
            inputWindow.inputTextBox.Text = instructionTextBoxText;
            inputWindow.Title = title;
            inputWindow.ShowDialog();
            string inputTextBoxData = inputWindow.inputTextBox.Text;
            return inputWindow.inputTextBox.Text.Split('|').ToList();
        }

        public static List<string> GetDataGridSelection(String instructionText, String instructionTextBoxText, String title, List<BasicDeviceInfo> inputData)
        {
            DataGridInput inputWindow = new DataGridInput();
            inputWindow.instructionTextBlock.Text = instructionText;
            inputWindow.radioGrid.ItemsSource = inputData;
            inputWindow.inputTextBox.Text = instructionTextBoxText;
            inputWindow.Title = title;
            inputWindow.ShowDialog();
            string inputTextBoxData = inputWindow.inputTextBox.Text;
            return inputWindow.inputTextBox.Text.Split('|').ToList();
        }

        /// <summary>
        /// Returns an absolute path to a file chosen by the user.
        /// </summary>
        /// <param name="fileType">File extension without the dot that you want to filter for, ex: "csv"</param>
        /// <returns></returns>
        public static string GetFileSelection(String fileType)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = "." + fileType.ToLower();
            dlg.Filter = fileType.ToUpper() + " Files (*." + fileType.ToLower() + ")|*." + fileType.ToLower();

            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog(); // The bool? means it can be null

            // Get the selected file name and return it 
            if (result == true)
            {
                // Return absolute file path 
                return dlg.FileName;
            } else
            {
                return null;
            }
        }

        /// <summary>
        /// Shows an info dialog without an extra button. (just OK)
        /// </summary>
        /// <param name="title">Title of window</param>
        /// <param name="subject">Header text</param>
        /// <param name="fullText">Full paragraph text</param>
        public static void ShowInfoDialog(string title, string subject, string fullText)
        {
            ShowInfoDialog(title, subject, fullText, new Button { IsEnabled = false });
        }
        
        /// <summary>
        /// Shows an info dialog with an extra button.
        /// </summary>
        /// <param name="title">Title of window</param>
        /// <param name="subject">Header text</param>
        /// <param name="fullText">Full paragraph text</param>
        /// <param name="extraButton">A Button object with the optional extra button.</param>
        /// <returns>A boolean showing whether the extra button was pressed or not.</returns>
        public static bool ShowInfoDialog(string title, string subject, string fullText, Button extraButton)
        {
            InfoDialog dialog = new InfoDialog();
            if(extraButton.IsEnabled)
            {
                dialog.ExtraButton.Content = extraButton.Text;
            } else
            {
                dialog.ExtraButton.Opacity = 0;
                dialog.ExtraButton.IsEnabled = false;
            }
            dialog.Subject.Text = subject;
            dialog.FullText.Text = fullText;
            dialog.Title = title;
            dialog.ShowDialog();
            if(dialog.FullText.Text == "ExtraButtonClicked")
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
