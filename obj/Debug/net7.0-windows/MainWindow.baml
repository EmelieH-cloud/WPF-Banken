   M S B A M L   `   `   `  ����E  AWPF-Banken, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_Banken
WPF_Banken  5   	       WPF_Banken.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_Banken     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ txtUserName��5      $��1��6'   $��10q�64   $��1��6@   $��2��6P   �� 5   
   -   5        $ txtPassWord��5      $��2��6'   $��10q�64   $��1��6@   $��2��6P   �� 5   
   -   5        $��BtnRegister��5      $��Register��6$   $��10q�67   $��2��6D   $��4��6T   $��18(�6a   6o   �� 5   
   -   5        $��BtnLogIn��5      $��Log in��6!   $��10q�62   $��2��6U   $��3��6e   $��18(�6r   �� 5   
   -   5        $��BtnAdminView��5      $��Admin��6%   $��10q�65   $��1��6A   $��3��6Q   $��18(�6^   6l   �� 5    
   $��	Username:��6   $��1��6$   $��Center=�61   $��Center=�6U   $��18(�6w   �� 5!   
   $��	Password:��6   $��2��6$   $��Center=�61   $��Center=�6U   $��18(�6w   �� 5"   
   -   5        $��lblUserNameFeedback��5"      $��Username feedback��6+   $��5��6G   $��1��6T   $��2��6d   $��Center=�6x   $��Center=�6�   $��18(�6�   �� 5#   
   -   5        $��lblPasswordFeedback��5#      $��Password feedback��6+   $��6��6G   $��1��6T   $��2��6d   $��Center=�6x   $��Center=�6�   $��18(�6�   5$      5%      