Computer gamingPC = new Computer.Builder()
    .SetCPU("Intel Core i9")
    .SetRAM("32GB")
    .SetStorage("1TB SSD")
    .Build();

gamingPC.Display();

Console.WriteLine();

Computer officePC = new Computer.Builder()
    .SetCPU("Intel Core i5")
    .SetRAM("16GB")
    .SetStorage("512GB SSD")
    .Build();

officePC.Display();