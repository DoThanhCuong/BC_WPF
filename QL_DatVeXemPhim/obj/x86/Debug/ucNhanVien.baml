   M S B A M L   `   `   `  ����J  FQL_DatVeXemPhim, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:QL_DatVeXemPhimQL_DatVeXemPhim  5           QL_DatVeXemPhim.ucNhanVien   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:QL_DatVeXemPhim     5      .��5	      � $��10q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��
dgNhanVien��5
   /       AutoGenerateColumns  .  $��0,228,-0.4,0q�6A      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã NV��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *MaNV+6Z     5      $ Họ và Tên��6%   $	 150 6R    68   �� *HoTen+6`     5      $ 
Ngày sinh��6%   $	 100 6U    68   �� *
NgaySinh+6c     5      $ Giới tính��6%   $ 60 6U    68   �� *
GioiTinh+6b     5      $ Địa chỉ��6%   $	 200 6Q    66   �� *DiaChi+6_     5      $ Email��6%   $	 100 6N    64   �� *Email+6\     5      $ Điện thoại��6%   $	 100 6Y    69   �� *SoDienThoai+6g   5      �� 5   
   -   5         ��Name$ label��5      $��Mã NV��6   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   $	��112��6u   �� 5   
   -   5        $ label1��5      $��Họ và Tên��6    $
��Left=�64   $��	10,41,0,0q�6O   $	��Top=�6b   $	��112��6z   �� 5   
   -   5        $ label2��5      $��
Ngày sinh��6    $
��Left=�64   $��	10,72,0,0q�6O   $	��Top=�6b   $	��112��6z   �� 5   
   -   5        $ label3��5      $��Label��6    $
��Left=�60   $��
10,114,0,0q�6K   $	��Top=�6_   $	��112��6w   �� 5   
   -   5        $ label4��5      $��Label��6    $
��Left=�60   $��
10,144,0,0q�6K   $	��Top=�6_   $	��112��6w   �� 5   
   -   5         ��Name$ txtMaNV��5      $
��Left=�6#   $��23��6>   $��
127,10,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ txtHoTen��5      $
��Left=�6$   $��23��6?   $��
127,41,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -	   5          Name$ dateNgaySinh��5      	   SelectedDateFormat$	 Short=�6+   $
��Left=�6F   $��
127,74,0,0q�6a   $	��Top=�6u   $	��120��6�   
   Text$
  ��6�   �� 5   
   -
   5        $ textBox3��5      $
��Left=�6$   $��23��6?   $��127,114,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ textBox4��5      $
��Left=�6$   $��23��6?   $��127,147,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5!   
   -   5         ��Name$ btnThem��5!      $��Thêm��6"   $
��Left=�61   $��137,195,0,0q�6L   $	��Top=�6a   $��75��6y   6�   �� 5"   
   -   5        $ btnNew��5"      $	��New��6!   $
��Left=�6/   $��
39,195,0,0q�6J   $	��Top=�6^   $��75��6v   6�   �� 5#   
   -   5        $ btnXoa��5#      $��Delete��6!   $
��Left=�62   $��230,195,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5$   
   -   5        $ 	btnUpdate��5$      $��Update��6$   $
��Left=�65   $��331,195,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5%   
   -   5         ��Name$ imgNhanVien��5%      $
��Left=�6%   $	��148��6@   $��
453,22,0,0q�6M   $	��Top=�6a   $	��137��6y   �� 5&   
   -   5        $ btnBrowseImgNV��5&      $��Browse��6)   $
��Left=�6:   $��485,195,0,0q�6U   $	��Top=�6j   $��75��6�   6�   5(      5)      