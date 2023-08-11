create trigger BaseLettersTrigger
on BaseLetters
after insert
as
begin
	declare
		@insertId int
		select @insertId = inserted.Id from inserted
	update BaseLetters
		set LetterKind = 
		(select "Name"
			from LetterKinds 
			where "Guid" = BaseLetters.LetterKindGuid),
	CreateDate = GETDATE()
	where BaseLetters.Id = @insertId
end

create trigger IncomingLettersTrigger
on IncomingLetters
after insert
as
begin
	declare
		@insertId int
		select @insertId = inserted.Id from inserted
	update IncomingLetters
		set LetterKind = 
			(select "Name"
				from LetterKinds 
				where "Guid" = IncomingLetters.LetterKindGuid),
	CreateDate = GETDATE()
	where IncomingLetters.Id = @insertId
end

drop trigger IncomingLettersTrigger