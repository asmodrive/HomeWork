int allPictures = 52;

int picturePerRow = 3;

int rowCount = allPictures / picturePerRow;

int extraPictures = allPictures % picturePerRow; 

Console.WriteLine($"Вы заполнили полностью {rowCount} строк, у вас остались свободные картинки {extraPictures}.");