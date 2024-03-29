USE [date_factory]
GO
/****** Object:  StoredProcedure [dbo].[add_vendor]    Script Date: 7/6/2019 11:38:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[add_vendor]
@ven_name varchar(50),
@ven_phone nchar(15),
@ven_address varchar(50),
@last_money float,
@ven_credit_limit float,
@ven_type  varchar(50),
@notes varchar(50),
@ven_image image
as


INSERT INTO [dbo].[vendors]
           ([ven_name]
           ,[ven_phone]
           ,[ven_address]
           ,[last_money]
           ,[ven_credit_limit]
           ,[ven_type]
           ,[notes]
           ,[ven_image])
     VALUES
           (@ven_name
           ,@ven_phone
           ,@ven_address
           ,@last_money
           ,@ven_credit_limit
           ,@ven_type
           ,@notes
           ,@ven_image)



GO
/****** Object:  StoredProcedure [dbo].[check_con]    Script Date: 7/6/2019 11:38:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[check_con]
as

SELECT [tb_id]
      ,[user_id]
      ,[user_name]
      ,[user_password]
      ,[user_full_name]
  FROM [dbo].[users]



GO
/****** Object:  StoredProcedure [dbo].[get_all_vendors]    Script Date: 7/6/2019 11:38:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[get_all_vendors]
as


SELECT [ven_id] as'كود المورد'
      ,[ven_name] as'اسم المورد'
      ,[ven_phone]as'رقم الهاتف'
      ,[ven_address]as'العنوان'
      ,[last_money]as'حساب اول المده'
      ,[ven_credit_limit]as'الحد الائتماني'
      ,[ven_type]as'النوع'
      ,[notes]as'ملاحظات'
      ,[ven_image]as'الصوره'
  FROM [dbo].[vendors]


GO
/****** Object:  StoredProcedure [dbo].[get_last_ven_id]    Script Date: 7/6/2019 11:38:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[get_last_ven_id]
AS
select  Isnull(max(ven_id)+1,1)from vendors
GO
/****** Object:  Table [dbo].[users]    Script Date: 7/6/2019 11:38:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[tb_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[user_name] [varchar](50) NULL,
	[user_password] [varchar](50) NULL,
	[user_full_name] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vendors]    Script Date: 7/6/2019 11:38:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vendors](
	[ven_id] [int] IDENTITY(1,1) NOT NULL,
	[ven_name] [varchar](50) NULL,
	[ven_phone] [nchar](15) NULL,
	[ven_address] [varchar](50) NULL,
	[last_money] [float] NULL,
	[ven_credit_limit] [float] NULL,
	[ven_type] [varchar](50) NULL,
	[notes] [varchar](50) NULL,
	[ven_image] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
