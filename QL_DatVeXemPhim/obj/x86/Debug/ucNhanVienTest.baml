   M S B A M L   `   `   `  ����J  FQL_DatVeXemPhim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:QL_DatVeXemPhimQL_DatVeXemPhim  5      $    QL_DatVeXemPhim.ucNhanVienTest   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:QL_DatVeXemPhim     5      .��5	      � $��0,0,-16.2,-87q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5           Name$  dataGrid��5
      $
��Left=�6%   $��
10,258,0,0q�6@   $	��Top=�6T   $	��219��6l   $	��671��6y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Mã��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   ��  �� Path$
 MaNV�  5      $ 	Họ tên��6g    6%   �� $ HoTen�   ClipboardContentBinding 6D   Z� 6g   4  .System.Windows.Controls.DataGridComboBoxColumn  5      $ Giới tính��6+   5      �� 5   
   -   5         ��Name$ imgNhanVien��5      $
��Left=�6%   $	��166��6@   $��
534,45,0,0q�6M   $	��Top=�6a   $	��115��6y   �� 5   
   -   5         ��Name$ txtHoTen��5   N   $
��Left=�6`   $��23��6{   $��
144,66,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��224��6�   ��6   �� *SelectedItem.HoTen+	 �� ElementName$	 dataGrid��6�   �� 5   
   -   5        
 ��Name$
 lblHoTen��5      $��	Họ tên��6"   $
��Left=�63   $��	92,62,0,0q�6N   $	��Top=�6a   �� 5   
   -   5         ��Name$ btnChonHinh��5      $	��...��6&   $
��Left=�64   $��534,216,0,0q�6O   $	��Top=�6d   $��28��6|   $��18��6�   6�   �� 5   
   -   5        $ btnSave��5      $
��Lưu��6"   $
��Left=�60   $��
90,218,0,0q�6K   $	��Top=�6_   $��75��6w   6�   �� 5   
   -   5        $ txtMa��5   M   $
��Left=�6\   $��23��6w   $��
144,31,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��224��6�   ��6   �� *SelectedItem.MaNV+$	 dataGrid��6�   �� 5   
   -   5        $
 lblMaNV��5      $��Mã NV��6!   $
��Left=�61   $��	92,27,0,0q�6L   $	��Top=�6_   �� 5   
   -	   5        $
 lblGioiTinh��5      $��Giới tính��6%   $
��Left=�69   $��	92,93,0,0q�6T   $	��Top=�6g   �� 5   
   -
   5         ��Name$ comboBox��5      $
��Left=�6%   $��
151,93,0,0q�6@   $	��Top=�6T   $	��217��6l   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $	��100��6:   $	��100��6F   ��6$   �� *Name+6F   �� 5      ��6$   �� *Name+5      5       5"      �� 5#   
   -   5        $
 label��5#      $��Địa chỉ��6   $
��Left=�61   $��104,124,0,0q�6L   $	��Top=�6a   �� 5$   
   -   5        $ 	txtDiaChi��5$      $
��Left=�6%   $��23��6@   $��156,127,0,0q�6L   $
 Wrap=�6a   $	��Top=�6�   $	��212��6�   ��6u   �� *SelectedItem.DiaChi+$	 dataGrid��6�   �� 5%   
   -   5        $
 label1��5%      $��Điện thoại��6    $
��Left=�65   $��
86,155,0,0q�6P   $	��Top=�6d   �� 5&   
   -   5        $ txtDienThoai��5&      $
��Left=�6(   $��23��6C   $��156,158,0,0q�6O   $
 Wrap=�6d   $	��Top=�6�   $	��212��6�   ��6x   �� *SelectedItem.SoDienThoai+$	 dataGrid��6�   54      55      