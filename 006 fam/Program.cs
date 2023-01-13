Console.WriteLine ("Ведите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "аня")
{
Console.WriteLine ("Ура, Хозяйка вернулась!");
}

else if (username.ToLower() == "аард")
{
Console.WriteLine ("Ты как зашла? У тебя же лапки!");
}

else if (username.ToLower() == "нуржан")
{
Console.WriteLine ("Ты замечательный, но у тебя есть свой комп");
}

else if (username.ToLower() == "федя")
{
Console.WriteLine ("А мама знает чем ты тут занимаешься?");
}

else
{
Console.Write (username);
Console.Write (", ты кто такой?! Давай досвидания!");
}