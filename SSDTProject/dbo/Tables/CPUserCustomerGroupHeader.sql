CREATE TABLE [dbo].[CPUserCustomerGroupHeader]
(
	[UserId] varchar(100) NOT NULL , 
    [GroupId] VARCHAR(15) NOT NULL, 
    [Authorized] CHAR(4) NOT NULL, 
    [NewRequest] BIT NOT NULL, 
    [DateRequested] DATETIME2 NOT NULL, 
    PRIMARY KEY ([UserId], [GroupId])
)
