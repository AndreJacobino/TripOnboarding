using TripOnboarding.VIewModels;

namespace TripOnboarding.View;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage(OnboardingViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}