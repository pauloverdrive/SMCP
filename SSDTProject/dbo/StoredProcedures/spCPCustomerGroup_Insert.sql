CREATE PROCEDURE [dbo].[spCPCustomerGroup_Insert]
	@GroupId varchar(15),
	@Name varchar(50)
AS
begin
	insert into dbo.CPCustomerGroup(GroupId, Name)
	values(@GroupId, @Name);
end
