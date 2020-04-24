﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinListViewCollectionView.Model;
using XamarinListViewCollectionView.Services;

namespace XamarinListViewCollectionView.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //Anterior
        public ObservableCollection<Pokemon> Pokemons { get; }
        private readonly PokemonService _pokemonService;


        public MainViewModel()
        {
            Pokemons = new ObservableCollection<Pokemon>();
            _pokemonService = new PokemonService();

        }

        public override async Task LoadAsync()
        {
            Ocupado = true;
            try
            {
                var pokemonsAPI = await _pokemonService.GetPokemonsAsync();

                Pokemons.Clear();

                foreach (var pokemon in pokemonsAPI)
                {
                    pokemon.Image = GetImageStreamFromUrl(pokemon.Sprites.FrontDefault.AbsoluteUri);
                    Pokemons.Add(pokemon);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Erro", ex.Message);
            }
            finally
            {
                Ocupado = false;
            }

        }


        public static byte[] GetImageStreamFromUrl(string url)
        {
            try
            {
                using (var webClient = new HttpClient())
                {
                    var imageBytes = webClient.GetByteArrayAsync(url).Result;

                    return imageBytes;

                }
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                return null;

            }
        }
    }
}
