CREATE PROCEDURE [dbo].[spCPCustomerGroup_Upsert]
	@GroupId varchar(15),
	@Name varchar(50)
AS
begin
	Merge dbo.CPCustomerGroup as [Target] 
	using (select GroupId = @GroupId, [Name]=@Name) as [Source] 
	on [Target].GroupId = [Source].GroupId 
	when Matched then 
	update set Target.[Name] = [Source].[Name]
	
	when not matched then
	insert (GroupId, [Name])
	values(@GroupId, @Name) ;
end
