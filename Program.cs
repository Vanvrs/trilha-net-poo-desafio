﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12434", modelo: "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone: ");
Smartphone iphone = new Iphone(numero: "124345", modelo: "Modelo 2", imei: "22222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");