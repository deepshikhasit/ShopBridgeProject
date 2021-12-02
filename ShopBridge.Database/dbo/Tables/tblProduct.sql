CREATE TABLE [dbo].[tblProduct]
(
	[ID] [int] Primary Key IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](Max) NULL,
	[Price] float NULL,
	[IsStatus] [bit] Default((1)) NULL,
	[IsDeleted] [bit] Default((0)) NULL,
	[CreatedDate] [dateTime] Default(getDate()) NULL,
	[UpdatedDate] [dateTime] Default(getDate()) NULL,
)
