using CompositePattern;

Role guest = new Role("Guest");
Role user = new Role("User");
Role admin = new Role("Admin");
Role developer = new Role("Developer");

Permission editCode = new Permission("EditCode");
Permission deleteCode = new Permission("DeleteCode");
Permission submitCode = new Permission("SubmitCode");
Permission reviewCode = new Permission("ReviewCode");

guest.Add(reviewCode);

user.Add(guest);
user.Add(submitCode);

developer.Add(user);
developer.Add(editCode);

admin.Add(developer);
admin.Add(deleteCode);

admin.Display();