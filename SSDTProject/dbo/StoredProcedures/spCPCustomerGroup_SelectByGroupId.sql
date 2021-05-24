CREATE PROCEDURE [dbo].[spCPCustomerGroup_SelectByGroupId]	
	@GroupId varchar(15)
AS
set nocount on;
begin
	SELECT [GroupId], [Name] from dbo.CPCustomerGroup
	WHERE [GroupId] = @GroupId;
end