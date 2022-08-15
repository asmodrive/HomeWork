int allPictures = 52;

int row = 3;

int rowCount = allPictures / row;

int extraPictures = allPictures % row; 

Console.WriteLine($"Вы заполнили полностью {rowCount} строк, у вас остались свободные картинки {extraPictures}.");