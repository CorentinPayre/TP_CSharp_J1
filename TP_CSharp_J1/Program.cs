using TP_CSharp_J1;

Book belAmi = new Book(1, "Guy de Maupassant", "Bel-Ami", 4.70, 1, "Available", "Classico Lycée", new DateTime(2015,04,12));
Book lEtranger = new Book(2, "Albert Camus", "L'Etranger", 7.40, 2, "Available", "Folio", new DateTime(2020,02,04));
Journal leMonde = new Journal(3, "Le Monde", "Le Monde", 1.3, 3, "On Hold", "Le Monde", new DateTime(2022 - 09 - 18), "Daily");
Magazine sciencesEtVie = new Magazine(4, "Science & Vie", "Science & Vie", 2.5, 4, "Not Available", "Science & Vie", new DateTime(2024 - 09 - 07), "Sciences");
StudyBook studySkills = new StudyBook(5, "Stella Cottrell", "The Study Skills HankBook", 25.80, 5, "Available", "Bloomsbury", new DateTime(2023 - 07 - 07), 2019, "Skills");

Console.WriteLine(belAmi.ToString());
Console.WriteLine(lEtranger.ToString());

