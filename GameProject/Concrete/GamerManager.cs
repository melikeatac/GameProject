using GameProject.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager:IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.GamerName + " " + gamer.GamerSurname + " isimli oyuncu eklendi...");

            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " " + gamer.GamerSurname + " isimli oyuncu silindi...");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " "+ gamer.GamerSurname+" isimli oyuncu güncellendi...");

        }
    }
}
