   M S B A M L   `   `   `  ���� H  DChromebookGUI, Version=1.1.3.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ChromebookGUIChromebookGUI      ChromebookGUI.TextBoxView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:ChromebookGUI     -     N� Title$  DefaultView��.��� .+��� -    ��Name$ submitDeviceId�� �� 	IsDefault . $��Submit��$
��Left=�$��
637,32,0,0q�$	��Top=�$	��124��$��32��$��18(����	#FF2D89EF
���������Z�  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     Color$ 	#FF6D6D6D��   Opacity$	 0.5Q��� -    ��Name$ deviceInputField��$
��Left=�$��32��$��	24,31,0,0q� �� TextWrapping$
 Wrap=�$J��DEnter a Device ID, Asset ID, Query String, Serial Number or Email...��$	��Top=�$	��586��$��18(� � Cursor$ IBeam���� $
��Left=�$��	24,80,0,0q�$
��Wrap=�$��Location��$	��Top=�$��16(��� -   $ LocationField��$��Set the Location...��$
��Left=�$��23��$��
24,107,0,0q�$
 Wrap=�$	��Top=�$	��138��$��14(�{�.  �� $
��Left=�$��
179,81,0,0q�$
��Wrap=�$��Asset ID��$	��Top=�$��16(��� -   $ AssetIdField��$��Set the Asset ID...��$
��Left=�$��23��$��179,107,0,0q�$
 Wrap=�$	��Top=�$	��138��$��14(�{�.  �� $
��Left=�$��
342,80,0,0q�$
��Wrap=�$
��User��$	��Top=�$��16(��� -   $ 	UserField��$��Set the User...��$
��Left=�$��23��$��342,107,0,0q�$
 Wrap=�$	��Top=�$	��138��$��14(�{�.  �� $
��Left=�$��
507,80,0,0q�$
��Wrap=�$��Status��$	��Top=�$��16(�	� -   	 	�Name$	 StatusDisabledRadio��$��Disabled��$
��Left=�$��507,111,0,0q�$	��Top=�{�.  	� -   $	 StatusActiveRadio��$��Active��$
��Left=�$��581,111,0,0q�$	��Top=�{�.  	� -	   $	 StatusDeprovisionedRadio��$��Deprovisioned��$
��Left=�$��637,111,0,0q�$	��Top=�{�.  �� $
��Left=�$��507,147,0,0q�$
��Wrap=�$��Organizational Unit��$	��Top=�$��16(��� -
   $ OrganizationalUnitField��$��Enter an OU or Browse...��$
��Left=�$��25��$��507,173,0,0q�$
 Wrap=�{�.  $	��Top=�$	��166��$��14(��� -   $$ OrganizationalUnitBrowseButton��$��	Browse...��$
��Left=�$��686,173,0,0q�$	��Top=�$��75��{�.  $��25���� $
��Left=�$��
24,147,0,0q�$
��Wrap=�$
��Note��$	��Top=�$��16(��� -   $ 	NoteField��$��Set a note...��$
��Left=�$��25��$��
24,173,0,0q�$
 Wrap=�$	��Top=�$	��456��$��14(�{�.  �� -   $ GetInfoButton��$��Get Info��$
��Left=�$��
24,213,0,0q�$	��Top=�$	��113��{�.  �� -   $ CopyDeviceIdButton��$��Copy Device ID��$
��Left=�$��142,213,0,0q�$	��Top=�$	��113��{�.  �� -   $ ApplyChangesButton��$��Apply Changes��$
��Left=�$��626,209,0,0q�$	��Top=�$	��136��$��16(����	#FF00A300
�������{�.  �� -   $ outputField��$��Stretch=�$
��Auto��$��24,286,33.286,10.143q�$
 Wrap=�$��Output will appear here.��$��Stretch=��� -   $��Copy output to clipboard��$
��Left=�$��
24,261,0,0q�$	��Top=�$	��156��
 J� RenderTransformOrigin$
 0.5,0.5&�$��20���� -   $ FontSizeUpButton��$��Font Size +��$
��Left=�$��687,261,0,0q�$	��Top=�$��75��$
 0.5,0.5&�$��20���� -   $ FontSizeDownButton��$��Font Size -��$
��Left=�$��607,261,0,0q�$	��Top=�$��75��$
 0.5,0.5&�$��20���� -   $ RevertChangesButton��$��Revert Changes��$
��Left=�$��485,209,0,0q�$	��Top=�$	��136��$��16(����	#FFB91D47
�������{�.  �� -    ��Name$ AutoCompleteBorder��
���   �
�������$
��Left=�$	��Top=�$	��0.5q�$	��586��$	��181��$��	24,63,0,0q�._��� $
��Auto=� J� Opacity$	 100Q�$��1,0,-1,0q�.���� -   $��deviceInputFieldStack��