# Game01

## 1.整体框架

使用Scroll Rect和Grid Layout Group实现排列页面和上下滑动的功能。物品数据通过Json文件读取存储在一个类对象的List里面，此处设计为单例模式。

## 2.目录结构 
｜——Scripts   
｜  ｜——DataManagers  
｜  ｜   ｜——DataManager     #数据管理  
｜  ｜   ｜——SetCardInfo     #设置商品信息  
｜  ｜   ｜——SimpleJson 		#读取Json文件数据     
｜ 	|      
｜  ｜——UIManager  
｜      ｜——BuyUIControl 	#显示购买标记  
｜ 	    ｜——ShowItem 		#展示商品信息  
｜      ｜——UIControl 		#初始界面按钮    
｜  
｜——Resources   
｜  ｜——Scripts  
｜     ｜——data 				#Json文件  
｜

## 3.代码逻辑分层

代码逻辑分为三层，分别是main、controller、model。 mian层负责读取和更新数据，controller控制界面的现实隐藏和商品信息的显示以及购买情况，model层显示界面具体信息。 除去Json读取数据的脚本程序有四个类，UIControl负责控制主界面显示，ShowItem负责显示商品的具体信息，BuyUIControl负责显示购买标记，DataManager负责更新购买数据，它的相应方法函数在BuyUIControl被调用

## 4.存储设计

物品数据存储在一个类对象的List里面。 卡片UI做成预制体以供使用，有三种prefab，分别是货币预制体，卡片预制体、未解锁卡片预制体，货币和卡片预制体可以根据需要修改显示的内容。

## 5.接口设计

物品数据通过Json文件读取存储在一个类对象的List里面，在其它类里可以通过此类提供的一个静态方法访问物品数据。

## 6.todo

后续优化：可以事先把资源数据都加载读入到一个字典里，避免经常加载资源。
