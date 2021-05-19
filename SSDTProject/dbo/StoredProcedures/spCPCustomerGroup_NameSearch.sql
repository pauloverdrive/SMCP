CREATE PROCEDURE [dbo].[spCPCustomerGroup_NameSearch]	
	@GroupIdFilter varchar(15),
	@NameFilter varchar(50)

AS
set nocount on;
begin
	SELECT [GroupId], [Name] from dbo.CPCustomerGroup
	WHERE [GroupId] LIKE @GroupIdFilter and [Name] LIKE @NameFilter;
end