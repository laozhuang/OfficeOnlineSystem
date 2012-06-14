-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- 主机: localhost
-- 生成日期: 2012 年 06 月 14 日 17:09
-- 服务器版本: 5.5.8
-- PHP 版本: 5.3.5

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- 数据库: `officeonline`
--

-- --------------------------------------------------------

--
-- 表的结构 `office`
--

CREATE TABLE IF NOT EXISTS `office` (
  `id` int(11) NOT NULL,
  `leader` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `office`
--


-- --------------------------------------------------------

--
-- 表的结构 `post_file`
--

CREATE TABLE IF NOT EXISTS `post_file` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `title` text NOT NULL,
  `content` text NOT NULL,
  `status` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=28 ;

--
-- 转存表中的数据 `post_file`
--

INSERT INTO `post_file` (`id`, `username`, `title`, `content`, `status`) VALUES
(11, 'demo', '这不是一个测试', '<b><font size="6" color="#ff0000">真的是测试</font></b>', -1),
(23, 'demo', '图片插入', '<b>测试图片插入如下：</b><div><img src="data:image/jpeg;base64,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"></div>', 0),
(24, 'demo', '草稿文件测试', '<b><font size="6">这是一个测试！！！</font></b><div><b><font size="6"><br></font></b></div>', -1),
(25, 'demo', 'WP8截图泄漏：集成Skype 全新相机界面(组图)', '<strong style="font-weight: 800; font-family: 宋体, arial, sans-serif; font-size: 14px; line-height: 25px; text-align: left; text-indent: 28px; background-color: rgb(255, 255, 255); ">腾讯科技讯</strong><span style="font-family: 宋体, arial, sans-serif; font-size: 14px; line-height: 25px; text-align: left; text-indent: 28px; background-color: rgb(255, 255, 255); ">（马乔）北京时间6月13日消息，据国外媒体报道，</span><span style="font-family: 宋体, arial, sans-serif; font-size: 14px; line-height: 25px; text-align: left; text-indent: 28px; background-color: rgb(255, 255, 255); "><a class="a-tips-Article-QQ" href="http://stockhtm.finance.qq.com/astock/ggcx/MSFT.OQ.htm" target="_blank" style="color: rgb(11, 59, 140); text-decoration: none; border-bottom-width: 1px; border-bottom-style: dotted; border-bottom-color: rgb(7, 129, 199); ">微软</a></span><span style="font-family: 宋体, arial, sans-serif; font-size: 14px; line-height: 25px; text-align: left; text-indent: 28px; background-color: rgb(255, 255, 255); ">下一代移动操作系统Windows Phone 8 Apollo将于6月20日在旧金山召开的开发者大会上亮相。但据最新获得的截图显示，Apollo将集成Skype，拥有全新相机界面和其他更多功能。</span><img src="http://img1.gtimg.com/tech/pics/hv1/31/250/1062/69120331.jpg">', 0),
(27, 'demo', '艺术滤镜升级 卡西欧EX-ZR300国内发布', '<p style="margin-top: 20px; margin-right: auto; margin-bottom: 0px; margin-left: auto; padding-top: 0px; padding-right: 0px; padding-bottom: 0px; padding-left: 0px; line-height: 25px; font-family: 宋体, arial, sans-serif; font-size: 14px; text-align: left; background-color: rgb(255, 255, 255); text-indent: 2em; ">2012年6月11日推出数码相机“EXILIM”高速ZR系列新成员——“EX-ZR300”。该机具有24mm广角12.5倍光学变焦镜头，内置兼顾高速拍摄功能与高速图像处理技术的“EXILIM ENGINE HS”引擎。<img src="http://img1.gtimg.com/digi/pics/hv1/162/51/1063/69134742.jpg"></p>', -1);

-- --------------------------------------------------------

--
-- 表的结构 `treat_file`
--

CREATE TABLE IF NOT EXISTS `treat_file` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` text NOT NULL,
  `content` text NOT NULL,
  `status` int(10) NOT NULL,
  `username` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- 转存表中的数据 `treat_file`
--

INSERT INTO `treat_file` (`id`, `title`, `content`, `status`, `username`) VALUES
(8, '不想做了', '<b><font size="5">郁闷</font></b>', 1, 'demo'),
(10, '明天打老虎', '  明天打老虎去  ', 2, 'demo'),
(11, '诺基亚宣布明年底前裁员1万人 管理层调整', '<img src="http://img1.gtimg.com/tech/pics/hv1/128/224/1063/69178823.jpg"><div><p style="margin-top: 20px; margin-right: auto; margin-bottom: 0px; margin-left: auto; padding-top: 0px; padding-right: 0px; padding-bottom: 0px; padding-left: 0px; line-height: 25px; font-family: 宋体, arial, sans-serif; font-size: 14px; text-align: left; background-color: rgb(255, 255, 255); text-indent: 2em; "><strong style="font-weight: 800; ">腾讯科技讯</strong>（无忌）北京时间6月14日消息，据国外媒体报道，诺基亚周四宣布，该公司将在全球裁员1万人，削减16亿欧元（约合20亿美元）支出；并警告称公司第二季度手机业务的亏损将会超过原先的预期。</p><p style="margin-top: 20px; margin-right: auto; margin-bottom: 0px; margin-left: auto; padding-top: 0px; padding-right: 0px; padding-bottom: 0px; padding-left: 0px; line-height: 25px; font-family: 宋体, arial, sans-serif; font-size: 14px; text-align: left; background-color: rgb(255, 255, 255); text-indent: 2em; ">自史蒂芬·埃洛普（Stephen Elop）2010年9月出任诺基亚首席执行官以来，诺基亚已经经历了数轮裁员。加上本轮裁员，埃洛普出任诺基亚首席执行官期间该公司的裁员总数已达到4万人。</p></div>', 1, 'demo');

-- --------------------------------------------------------

--
-- 表的结构 `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `username` varchar(20) NOT NULL,
  `password` varchar(128) NOT NULL,
  `office_id` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `role` tinyint(1) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 转存表中的数据 `users`
--

INSERT INTO `users` (`username`, `password`, `office_id`, `email`, `role`) VALUES
('admin', 'admin', 1, 'abcd@cba.com', 1),
('demo', 'demo', 1, 'abc@cba.com', 0),
('stranger', 'nopassword', 0, 'none', -1);
