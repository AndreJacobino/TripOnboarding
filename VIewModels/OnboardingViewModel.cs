using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripOnboarding.Models;

namespace TripOnboarding.VIewModels
{
    public partial class OnboardingViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<OnboardingItem> _itens;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsLastPosicao))]
        [NotifyPropertyChangedFor(nameof(ExibirBotao))]
        private int _posicao;

        public bool IsLastPosicao => Posicao == Itens.Count - 1;

        public bool ExibirBotao => !IsLastPosicao;

        public OnboardingViewModel()
        {
            Itens = new List<OnboardingItem>
            {
                new OnboardingItem
                {
                    Titulo = "Explore \r\nExotic Destinations",
                    Descricao = "Embark on a virtual journey through stunning destinations worldwide.",
                    ImagemUrl = "primeira.png"
                },
                new OnboardingItem
                {
                    Titulo = "Discover \r\nLocal Gemss",
                    Descricao = "Uncover hidden gems and local favorites recommended by fellow travelers.",
                    ImagemUrl = "segundo.png"
                },
                new OnboardingItem
                {
                    Titulo = "Plan \r\nYour Perfect Trip",
                    Descricao = "Create personalized itineraries tailored to your preferences and interests.",
                    ImagemUrl = "terceiro.png"
                },
                new OnboardingItem
                {
                    Titulo = "Capture and Share Memories",
                    Descricao = "Preserve your travel memories with our in-app photo and journaling features.",
                    ImagemUrl = "quarta.png"
                }
            };
        }
        [RelayCommand]
        private void proximo()
        {
            if (Posicao < Itens.Count - 1)
            {
                Posicao++;
            }
        }
    }
}