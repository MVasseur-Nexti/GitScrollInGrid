using Syncfusion.SfAutoComplete.XForms;
using System.Linq;
using Xamarin.Forms;

namespace GridInScrollView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            addRows(3);
        }

        private void addRows(int nbr, bool sansChild = false)
        {
            for (int i = 0; i < nbr; i++)
            {
                RowDefinition row = null;

                if (gridLignes.RowDefinitions.Count > 0 && gridLignes.Children.Count == 0)
                {
                    row = gridLignes.RowDefinitions[0];
                }
                else
                {
                    row = new RowDefinition();

                    gridLignes.RowDefinitions.Add(row);
                }

                row.Height = GridLength.Auto;//new GridLength(1, GridUnitType.Star);

                if (!sansChild)
                {
                    Entry entryId = new Entry();
                    entryId.Keyboard = Keyboard.Numeric;
                    entryId.HorizontalTextAlignment = TextAlignment.Center;
                    entryId.TextColor = Color.Black;
                    gridLignes.Children.Add(entryId);
                    Grid.SetRow(entryId, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(entryId, 0);

                    Entry entryPMG = new Entry();
                    entryPMG.Keyboard = Keyboard.Numeric;
                    entryPMG.HorizontalTextAlignment = TextAlignment.Center;
                    entryPMG.FontSize = 14;
                    entryPMG.TextColor = Color.Black;;
                    gridLignes.Children.Add(entryPMG);
                    Grid.SetRow(entryPMG, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(entryPMG, 1);

                    SfAutoComplete autoCompleteEspece = new SfAutoComplete();
                    autoCompleteEspece.DropDownWidth = 1000;
                    autoCompleteEspece.DisplayMemberPath = "Libelle";
                    autoCompleteEspece.ShowSuggestionsOnFocus = true;
                    autoCompleteEspece.Watermark = "Espèce";
                    autoCompleteEspece.TextColor = Color.Black;
                    autoCompleteEspece.SuggestionMode = SuggestionMode.Contains;
                    autoCompleteEspece.WidthRequest = 150;
                    autoCompleteEspece.TextSize = 14;
                    autoCompleteEspece.DropDownTextSize = 18;
                    gridLignes.Children.Add(autoCompleteEspece);
                    Grid.SetRow(autoCompleteEspece, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(autoCompleteEspece, 2);

                    SfAutoComplete autoCompleteVariete = new SfAutoComplete();
                    autoCompleteVariete.DropDownWidth = 1000;
                    autoCompleteVariete.DisplayMemberPath = "Libelle";
                    autoCompleteVariete.Watermark = "Variété";
                    autoCompleteVariete.ShowSuggestionsOnFocus = true;
                    autoCompleteVariete.TextColor = Color.Black;
                    autoCompleteVariete.WidthRequest = 150;
                    autoCompleteVariete.TextSize = 14;
                    autoCompleteVariete.DropDownTextSize = 18;
                    autoCompleteVariete.SuggestionMode = SuggestionMode.Contains;
                    gridLignes.Children.Add(autoCompleteVariete);
                    Grid.SetRow(autoCompleteVariete, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(autoCompleteVariete, 3);

                    SfAutoComplete autoCompleteArticle = new SfAutoComplete();
                    autoCompleteArticle.DropDownWidth = 1000;
                    autoCompleteArticle.DisplayMemberPath = "codePlusLibelle";
                    autoCompleteArticle.Watermark = "Article";
                    autoCompleteArticle.ShowSuggestionsOnFocus = true;
                    autoCompleteArticle.TextColor = Color.Black;
                    autoCompleteArticle.TextSize = 14;
                    autoCompleteArticle.DropDownTextSize = 18;
                    autoCompleteArticle.SuggestionMode = SuggestionMode.Contains;
                    gridLignes.Children.Add(autoCompleteArticle);
                    Grid.SetRow(autoCompleteArticle, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(autoCompleteArticle, 4);

                    Editor labelDesciptionArticle = new Editor();
                    //labelDesciptionArticle.LineBreakMode = LineBreakMode.WordWrap;
                    labelDesciptionArticle.TextColor = Color.Black;
                    //labelDesciptionArticle.VerticalTextAlignment = TextAlignment.Center;
                    labelDesciptionArticle.Placeholder = "Enter text here";
                    labelDesciptionArticle.AutoSize = EditorAutoSizeOption.TextChanges;
                    labelDesciptionArticle.FontSize = 20;
                    labelDesciptionArticle.Text = "";
                    gridLignes.Children.Add(labelDesciptionArticle);
                    Grid.SetRow(labelDesciptionArticle, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(labelDesciptionArticle, 5);

                    SfAutoComplete autoCompleteLot = new SfAutoComplete();
                    autoCompleteLot.DropDownWidth = 1000;
                    autoCompleteLot.DisplayMemberPath = "Libelle";
                    autoCompleteLot.Watermark = "Lot";
                    autoCompleteLot.ShowSuggestionsOnFocus = true;
                    autoCompleteLot.VerticalOptions = LayoutOptions.FillAndExpand;
                    autoCompleteLot.MultiSelectMode = MultiSelectMode.Token;
                    autoCompleteLot.TokensWrapMode = TokensWrapMode.Wrap;
                    autoCompleteLot.IsSelectedItemsVisibleInDropDown = false;
                    autoCompleteLot.TextColor = Color.Black;
                    autoCompleteLot.TextSize = 14;
                    autoCompleteLot.DropDownTextSize = 18;
                    autoCompleteLot.SuggestionMode = SuggestionMode.Contains;
                    autoCompleteLot.EnableAutoSize = false;
                    gridLignes.Children.Add(autoCompleteLot);
                    Grid.SetRow(autoCompleteLot, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(autoCompleteLot, 6);

                    Entry entryQuantitePrevisionnelle = new Entry();
                    entryQuantitePrevisionnelle.Keyboard = Keyboard.Numeric;
                    entryQuantitePrevisionnelle.HorizontalTextAlignment = TextAlignment.Center;
                    entryQuantitePrevisionnelle.FontSize = 14;
                    entryQuantitePrevisionnelle.TextColor = Color.Black;
                    gridLignes.Children.Add(entryQuantitePrevisionnelle);
                    Grid.SetRow(entryQuantitePrevisionnelle, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(entryQuantitePrevisionnelle, 7);

                    CheckBox checkConformePrevisionnel = new CheckBox();
                    checkConformePrevisionnel.IsChecked = true;
                    checkConformePrevisionnel.HorizontalOptions = LayoutOptions.Center;
                    gridLignes.Children.Add(checkConformePrevisionnel);
                    Grid.SetRow(checkConformePrevisionnel, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(checkConformePrevisionnel, 8);

                    Entry entryNonConformePrevisionnel = new Entry();
                    entryNonConformePrevisionnel.HorizontalTextAlignment = TextAlignment.Center;
                    entryNonConformePrevisionnel.TextColor = Color.Black;
                    entryNonConformePrevisionnel.FontSize = 14;
                    gridLignes.Children.Add(entryNonConformePrevisionnel);
                    Grid.SetRow(entryNonConformePrevisionnel, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(entryNonConformePrevisionnel, 9);

                    Entry entryQuantiteReelle = new Entry();
                    entryQuantiteReelle.Keyboard = Keyboard.Numeric;
                    entryQuantiteReelle.HorizontalTextAlignment = TextAlignment.Center;
                    entryQuantiteReelle.FontSize = 14;
                    entryQuantiteReelle.TextColor = Color.Black;
                    gridLignes.Children.Add(entryQuantiteReelle);
                    Grid.SetRow(entryQuantiteReelle, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(entryQuantiteReelle, 10);

                    Button btnSupprimerLigne = new Button();
                    btnSupprimerLigne.Text = "X";
                    btnSupprimerLigne.TextColor = Color.Red;
                    btnSupprimerLigne.FontSize = 30;
                    gridLignes.Children.Add(btnSupprimerLigne);
                    Grid.SetRow(btnSupprimerLigne, gridLignes.RowDefinitions.Count - 1);
                    Grid.SetColumn(btnSupprimerLigne, 11);
                }
            }
        }
    }
}
