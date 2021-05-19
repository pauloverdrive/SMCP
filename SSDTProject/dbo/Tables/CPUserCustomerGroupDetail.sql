CREATE TABLE [dbo].[CPUserCustomerGroupDetail]
(
	[GroupId] CHAR(15) NOT NULL, 
    [RecordType] CHAR(6) NOT NULL,
    [UserId] char(100),
    [Company] INT NOT NULL, 
    [Customer] DECIMAL(10) NOT NULL, 
    [ShipTo] CHAR(10) not null, 
    CONSTRAINT [PK_CPUserCustomerAssignments] PRIMARY KEY NONCLUSTERED ([GroupId],[RecordType],[UserId],[Company],[Customer],[ShipTo])
)
