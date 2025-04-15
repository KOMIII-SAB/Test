USE [Test]
GO
/****** Object:  Table [dbo].[FinanceDetails]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinanceDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[propertyid] [varchar](25) NOT NULL,
	[propertytype] [varchar](25) NULL,
	[location] [varchar](100) NULL,
	[propertysize] [varchar](10) NULL,
	[purchaseprice] [varchar](25) NULL,
	[marketvalue] [varchar](25) NULL,
	[propertyage] [varchar](5) NULL,
	[renovationcost] [varchar](25) NULL,
	[createddate] [datetime] NULL,
	[createdby] [varchar](50) NULL,
	[modifieddate] [datetime] NULL,
	[modifiedby] [varchar](50) NULL,
 CONSTRAINT [PK_FinanceDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[logs]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tablename] [nvarchar](100) NULL,
	[actiontype] [nvarchar](10) NULL,
	[recordid] [nvarchar](100) NULL,
	[name] [nvarchar](100) NULL,
	[date] [datetime] NULL,
 CONSTRAINT [PK_logs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyOperations]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyOperations](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[propertyid] [varchar](50) NOT NULL,
	[propertytype] [varchar](25) NULL,
	[location] [varchar](100) NULL,
	[status] [varchar](25) NULL,
	[startlease] [date] NULL,
	[endlease] [date] NULL,
	[createddate] [date] NULL,
	[createdby] [varchar](50) NULL,
	[modifieddate] [date] NULL,
	[modifiedby] [varchar](50) NULL,
 CONSTRAINT [PK_PropertyOperations] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userid] [text] NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[datecreated] [datetime] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[FinanceDetails] ADD  CONSTRAINT [DF_FinanceDetails_createddate]  DEFAULT (getdate()) FOR [createddate]
GO
ALTER TABLE [dbo].[logs] ADD  CONSTRAINT [DF_logs_date]  DEFAULT (getdate()) FOR [date]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_datecreated]  DEFAULT (getdate()) FOR [datecreated]
GO
/****** Object:  StoredProcedure [dbo].[FinanceDetailsGetAllRecord]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FinanceDetailsGetAllRecord] 
AS
BEGIN
	SET NOCOUNT ON;

    SELECT 
        id AS [ID],
        propertyid AS [Property ID],
        propertytype AS [Property Type],
        location AS [Location],
        propertysize AS [Property Size],
        purchaseprice AS [Purchase Price],
        marketvalue AS [Market Value],
        propertyage AS [Property Age],
        renovationcost AS [Renovation Cost],
        createddate AS [Created Date],
        createdby AS [Created By],
        modifieddate AS [Modified Date],
        modifiedby AS [Modified By]
    FROM 
        FinanceDetails;
END
GO
/****** Object:  StoredProcedure [dbo].[FinanceDetailsGetRecordById]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FinanceDetailsGetRecordById]
@Id INT
AS
BEGIN
	SET NOCOUNT ON;

   SELECT 
        id,
        propertyid,
        propertytype,
        location,
        propertysize,
        purchaseprice,
        marketvalue,
        propertyage,
        renovationcost,
        createddate,
        createdby,
        modifieddate,
        modifiedby
    FROM FinanceDetails
    WHERE id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[FinanceDetailsInsert]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FinanceDetailsInsert] 
	@PropertyID TEXT,
    @PropertyType VARCHAR(25),
    @Location VARCHAR(100),
    @PropertySize VARCHAR(10),
    @PurchasePrice INT,
    @MarketValue INT,
    @PropertyAge INT,
    @RenovationCost INT
AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO FinanceDetails (propertyid, propertytype, location, propertysize, purchaseprice, marketvalue, propertyage, renovationcost, createdby)
    VALUES (@PropertyID, @PropertyType, @Location, @PropertySize, @PurchasePrice, @MarketValue, @PropertyAge, @RenovationCost, '6133C8F2322B446F')

	-- Log the action
	INSERT INTO logs (tablename, actiontype, recordid, name)
    VALUES ('FinanceDetails', 'INSERT', @PropertyID, '6133C8F2322B446F')
END
GO
/****** Object:  StoredProcedure [dbo].[FinanceDetailsSearch]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FinanceDetailsSearch]
@searchTerm VARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

   SELECT 
        id AS [ID],
        propertyid AS [Property ID],
        propertytype AS [Property Type],
        location AS [Location],
        propertysize AS [Property Size],
        purchaseprice AS [Purchase Price],
        marketvalue AS [Market Value],
        propertyage AS [Property Age],
        renovationcost AS [Renovation Cost],
        createddate AS [Created Date],
        createdby AS [Created By],
        modifieddate AS [Modified Date],
        modifiedby AS [Modified By]
    FROM 
        FinanceDetails
    WHERE 
        propertyid LIKE '%' + @searchTerm + '%' OR
        propertytype LIKE '%' + @searchTerm + '%' OR
        location LIKE '%' + @searchTerm + '%' OR
        propertysize LIKE '%' + @searchTerm + '%' OR
        purchaseprice LIKE '%' + @searchTerm + '%' OR
        marketvalue LIKE '%' + @searchTerm + '%' OR
        propertyage LIKE '%' + @searchTerm + '%' OR
        renovationcost LIKE '%' + @searchTerm + '%';
END
GO
/****** Object:  StoredProcedure [dbo].[FinanceDetailsUpdate]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[FinanceDetailsUpdate] 
	@PropertyID VARCHAR(25),
    @PropertyType VARCHAR(25),
    @Location VARCHAR(100),
    @PropertySize VARCHAR(10),
    @PurchasePrice INT,
    @MarketValue INT,
    @PropertyAge INT,
    @RenovationCost INT
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE FinanceDetails
    SET 
        propertytype = @PropertyType,
        location = @Location,
        propertysize = @PropertySize,
        purchaseprice = @PurchasePrice,
        marketvalue = @MarketValue,
        propertyage = @PropertyAge,
        renovationcost = @RenovationCost,
        modifieddate = GETDATE(),
        modifiedby = '6133C8F2322B446F'
    WHERE propertyid = @PropertyID

	-- Log the action
	INSERT INTO logs (tablename, actiontype, recordid, name)
    VALUES ('FinanceDetails', 'UPDATE', @PropertyID, '6133C8F2322B446F')
END
GO
/****** Object:  StoredProcedure [dbo].[PropertyOperationsInsert]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PropertyOperationsInsert] 
	@PropertyID VARCHAR(50), 
	@PropertyType VARCHAR(25), 
	@Location VARCHAR(100), 
    @Status VARCHAR(25), 
	@StartLease DATE, 
	@EndLease DATE
AS
BEGIN
	SET NOCOUNT ON;

    INSERT INTO PropertyOperations (propertyid, propertytype, location, status, startlease, endlease, createdby, createddate)
    VALUES (@PropertyID, @PropertyType, @Location, @Status, @StartLease, @EndLease, '6133C8F2322B446F', GETDATE());

	-- Log the action
	INSERT INTO logs (tablename, actiontype, recordid, name)
    VALUES ('PropertyOperations', 'INSERT', @PropertyID, '6133C8F2322B446F')
END
GO
/****** Object:  StoredProcedure [dbo].[PropertyOperationsSearch]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PropertyOperationsSearch]
@searchTerm VARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;

   SELECT 
        id AS [ID],
        propertyid AS [Property ID],
        propertytype AS [Property Type],
        location AS [Location],
        status AS [Status],
        startlease AS [Start Lease],
        endlease AS [End Lease],
        createddate AS [Created Date],
        createdby AS [Created By],
        modifieddate AS [Modified Date],
        modifiedby AS [Modified By]
    FROM 
        PropertyOperations
    WHERE 
        propertyid LIKE '%' + @searchTerm + '%' OR
        propertytype LIKE '%' + @searchTerm + '%' OR
        location LIKE '%' + @searchTerm + '%' OR
        status LIKE '%' + @searchTerm + '%' OR
        startlease LIKE '%' + @searchTerm + '%' OR
        endlease LIKE '%' + @searchTerm + '%';
END
GO
/****** Object:  StoredProcedure [dbo].[PropertyOperationsSearchGetAllRecord]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PropertyOperationsSearchGetAllRecord] 
AS
BEGIN
	SET NOCOUNT ON;

    SELECT 
        id AS [ID],
        propertyid AS [Property ID],
        propertytype AS [Property Type],
        location AS [Location],
        status AS [Status],
        startlease AS [Start Lease],
        endlease AS [End Lease],
        createddate AS [Created Date],
        createdby AS [Created By],
        modifieddate AS [Modified Date],
        modifiedby AS [Modified By]
    FROM 
        PropertyOperations;
END
GO
/****** Object:  StoredProcedure [dbo].[PropertyOperationsSearchGetRecordById]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PropertyOperationsSearchGetRecordById]
@Id INT
AS
BEGIN
	SET NOCOUNT ON;

   SELECT 
        id,
        propertyid,
        propertytype,
        location,
        status,
        startlease,
        endlease,
        createddate,
        createdby,
        modifieddate,
        modifiedby
    FROM PropertyOperations
    WHERE id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[PropertyOperationsUpdate]    Script Date: 15/04/2025 9:44:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PropertyOperationsUpdate] 
	@PropertyID VARCHAR(50), 
	@PropertyType VARCHAR(25), 
	@Location VARCHAR(100), 
    @Status VARCHAR(25), 
	@StartLease DATE, 
	@EndLease DATE
AS
BEGIN
	SET NOCOUNT ON;

    UPDATE PropertyOperations
    SET 
        propertytype = @PropertyType,
        location = @Location,
        status = @Status,
        startlease = @StartLease,
        endlease = @EndLease,
        modifieddate = GETDATE(),
        modifiedby = '6133C8F2322B446F'
    WHERE propertyid = @PropertyID

	-- Log the action
	INSERT INTO logs (tablename, actiontype, recordid, name)
    VALUES ('PropertyOperations', 'UPDATE', @PropertyID, '6133C8F2322B446F')
END
GO
