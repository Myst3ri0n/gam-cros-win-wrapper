   M S B A M L   `   `   `  ���� H  DChromebookGUI, Version=1.0.2.8, Culture=neutral, PublicKeyToken=null-clr-namespace:ChromebookGUIChromebookGUI      ChromebookGUI.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:ChromebookGUI       � Title$  ChromebookGUI��$	��500��$	��800��.��� $��	10,0,10,0q� � RowDefinitions �� $
��auto ��� $
��auto ��� $��1* �.+��� -    ��Name$ submitDeviceId�� �� 	IsDefault . $��Submit��$
��Left=�$��
613,58,0,0q�$	��Top=�$	��120��$��30��$��18(����	#FF2D89EF
���������Z�  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ 	#FF6D6D6D��   Opacity$	 0.5Q��� -    ��Name$ deviceInputField��$
��Left=�$��30��$��	24,58,0,0q� �� TextWrapping$
 Wrap=�$J��DEnter a Device ID, Asset ID, Query String, Serial Number or Email...��$	��Top=�$	��564��$��18(�	 � Cursor$	 IBeam���� -   $ outputField��$��Stretch=�$
��Auto��$��24,10.429,41.286,31.714q�$
 Wrap=�$��Output will appear here.��$��Stretch=�$
��Auto=�$��2��$
��Auto���� -   $ getInfoButton��$��Get Info��$
��Left=�$��
24,120,0,0q�$	��Top=�$	��120��$��32��$��18(��� -   $ setLocationButton��$��Set Location��$
��Left=�$��173,120,0,0q�$	��Top=�$	��120��$��32��$��18(��� -   $ setAssetIdButton��$��Set Asset ID��$
��Left=�$��322,120,0,0q�$	��Top=�$	��120��$��32��$��18(�
 J� RenderTransformOrigin$
 0.506,0.555&��� -   $ setUserButton��$��Set User��$
��Left=�$��468,120,0,0q�$	��Top=�$	��120��$��32��$��18(��� -   $ disableButton��$��Disable��$
��Left=�$��613,120,0,0q�$	��Top=�$	��120��$��32��$��18(��� -	   $ enableButton��$��Enable��$
��Left=�$��
24,181,0,0q�$	��Top=�$	��120��$��32��$��18(�$
 0.508,0.519&��� -
   $ changeOuButton��$��	Change OU��$
��Left=�$��173,181,0,0q�$	��Top=�$	��120��$��32��$��18(�$
 0.508,0.519&��� -   $ deprovisionButton��$��Deprovision��$
��Left=�$��322,181,0,0q�$	��Top=�$	��120��$��32��$��18(�$
 0.508,0.519&��� -   $ 
noteButton��$��	Edit Note��$
��Left=�$��468,181,0,0q�$	��Top=�$	��120��$��32��$��18(�$
 0.508,0.519&��� -   $ copyIdButton��$��Copy ID��$
��Left=�$��613,181,0,0q�$	��Top=�$	��120��$��32��$��18(�$
 0.508,0.519&��� -   $��Copy output to clipboard��$
��Left=�$��
24,236,0,0q�$	��Top=�$	��150��$
 0.5,0.5&��� -   $ FontSizeUpButton��$��Font Size +��$
��Left=�$��661,236,0,0q�$	��Top=�$��72��$
 0.5,0.5&�$��3���� -   $ FontSizeDownButton��$��Font Size -��$
��Left=�$��583,236,0,0q�$	��Top=�$��72��$
 0.5,0.5&�$��3��o� $��Stretch=�$��30��$��Stretch=�$
��Auto��$��-10,0,-10,225.96q�.@�m� $
��File��$��29��$��36��.@�m� -    m�Name$ FilePreferences��$��_Preferences...��m� -   $ FileCloseChromebookGUI��$��_Close ChromebookGUI���� m� -   $ FileAboutChromebookGUI��$��_About ChromebookGUI��m� $��_Import��.@�m� -   $ ImportFromCSV��$��_From CSV...��m� -   $* $BulkImportFromGoogleAdminQueryString��$7��1_From Google Admin Console Query String (Bulk)...��m� $��_Window��.@�m� -   $ Window_ResetWindowSize��$��_Reset Window Size��m� $��_Help��.@�m� -   $ HelpGoToGithubProject��$��_Go to GitHub Project...��m� -   $ 
HelpGuides��$��_Guides��.@�m� -   $# HelpGuidesSearchingTheOmnibar��$��_Searching the Omnibar��m� -   $ HelpCheckForUpdates��$��_Check for Updates...��