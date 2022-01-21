using HomeWorke2._1;

    Starter starter = new Starter();
    int logQuantity = 100;
    starter.Start(logQuantity);
    Logger.Instance.SavelogToFile(logQuantity);