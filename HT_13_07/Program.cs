using HT_13_07.Services;

PersonServices personServices = new PersonServices();

personServices.AddPerson("Nurmuhammad", "Davletov");
personServices.UpdatePerson(1, "G'olibjon", "Davletov");
personServices.DeletePerson(1);