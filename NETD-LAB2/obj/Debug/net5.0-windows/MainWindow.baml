   M S B A M L   `   `   `  ????D  @NETD-LAB2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NETD_LAB2	NETD_LAB2  5   	   E AFluentWPF, Version=0.10.2.0, Culture=neutral, PublicKeyToken=nullP6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPFSourceChord.FluentWPF 5   	       NETD_LAB2.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5	   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5
   	   )localclr-namespace:NETD_LAB2     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   ?fw6clr-namespace:SourceChord.FluentWPF;assembly=FluentWPF  5   	   -   5        )  #SourceChord.FluentWPF.AcrylicWindow    Enabled$
  True??5   	      AcrylicWindowStyle$
 None=?5   	   $??15(?6Q   $	??600??6_   $
??1080??6l    ? WindowStyle$
 None=?6y    ? AllowsTransparency$
 True??6?    ? 
ResizeMode$ NoResize=?6?    ? WindowStartupLocation$ CenterScreen=?6?   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??350 ?6   ?? 5      $??* ?6   .+?5   
   ? *  $SourceChord.FluentWPF.PointerTracker   Enabled$
 True??6   ???	#01FFFFFF.+?5   
   ?? .+?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $??Midsize LLP??6   $??18(?6/   $??10q?6=   $??Center=?6I   5      ?? 5       -   5        $??12(?5       .@?5!      ?? -   5        	 ??Name$	 changeLendOut??5!   /   $??1q?6#   .??5"      ?? $ 
Horizontal=?6%   .+?5#      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$

 Send=?66   $??15q?6B   ?? 5$      $??Lend Out??6(   $??Center=?68   5%      5&      ?? 5)      -   5        $	 changeViewLendOut??5)   /   $??1q?6#   .??5*      ?? $ 
Horizontal=?6%   .+?5+        $
 Monitor=?66   $??15q?6E   ?? 5,      $??View Lend Out??6(   $??Center=?6=   5-      5.      ?? 51      -   5        $	 changeSearch??51   /   $??1q?6#   .??52      ?? $ 
Horizontal=?6%   .+?53        $
 Monitor=?66   $??15q?6E   ?? 54      $??Search??6(   $??Center=?66   55      56      58      59      5:      ? 5<   
   -   5         ?Name$ ContentPanel??5<   2   $??1??6   
???????5=      5?      5B      