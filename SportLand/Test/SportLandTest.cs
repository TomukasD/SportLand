using NUnit.Framework;

namespace SportLand.Test
{
    public class SportLandTest : BaseTest
    {
        [Test, Order(1)]
        public static void OpenSearchBarResults()
        {
            _SportLandMainPage.NavigateToPage();
            _SportLandMainPage.CloseCookies();
            _SportLandMainPage.SearchByText("vyriski batai");
            _SportLandMainPage.ClickOnSearchBarOptions();
            _SportLandSearchResultsPage.VerifyClickedSearchField();
        }

        [Test, Order(2)]
        public static void SearchBarResultsCheckBrandNamesFilter()
        {
            _SportLandSearchResultsPage.CloseCookies();
            _SportLandSearchResultsPage.ClickBrandNames();
            _SportLandSearchResultsPage.ClickBrandNike();
            _SportLandSearchResultsPage.ClickBrandConverse();
            _SportLandSearchResultsPage.ClickBrandVans();
            _SportLandSearchResultsPage.ClickBrandTimberlands();
            _SportLandSearchResultsPage.DeClickBrandTimberlands();
            _SportLandSearchResultsPage.DeClickBrandVans();
            _SportLandSearchResultsPage.VerifySelectedBrands();
        }
        [Test, Order(3)]
        public static void SearchBarResultsSortBy()
        {
            _SportLandSearchResultsPage.SortByClick();
            _SportLandSearchResultsPage.HighestPriceChoose();
            _SportLandSearchResultsPage.VerifySelectedPriceFilter();
        }
        [Test, Order(4)]
        public static void SelectNikeShoes()
        {
            _SportLandSearchResultsPage.ChoosenikeZoomXVapourFlyNext();
            _SportLandSearchResultsPage.VerifySelectedNike();
        }
        [Test, Order(5)]
        public static void SelectedNikeShoesPage()
        {
            _nikeZoomXVapourFlyNextPage.NikeShoeSize();
            _nikeZoomXVapourFlyNextPage.NikeNextSlide();
            _nikeZoomXVapourFlyNextPage.NikeBuy();
            _nikeZoomXVapourFlyNextPage.VerifyBoughtNikeBasketPopOut();
        }
        [Test, Order(6)]
        public static void ReturnToResultsPage()
        {
            _nikeZoomXVapourFlyNextPage.CloseShoeBasketPopOut();
            _nikeZoomXVapourFlyNextPage.ReturnToResultsPage();
            _SportLandSearchResultsPage.VerifyBackToResultsPage();
        }

    [Test, Order(7)]
        public static void SelectConverseShoes()
        {
            _SportLandSearchResultsPage.ChooseConverseMCtasTerranHi();
            _SportLandSearchResultsPage.VerifySelectedConverse();
        }
        [Test, Order(8)]
        public static void SelectedConversePage()
        {
            _ConverseMCtasTerranHiPage.ConverseShoeSizeSelect();
            _ConverseMCtasTerranHiPage.ConverseShoeBuy();
            _ConverseMCtasTerranHiPage.VerifyBoughtConverseBasketPopUp();
            _ConverseMCtasTerranHiPage.PopUpOpenGoToCart();
            _ConverseMCtasTerranHiPage.VerifyGoToCartPage();
        }
        [Test, Order(9)]
        public static void CartPage()
        {
            _SportLandCartPage.AddNike();
            _SportLandCartPage.VerifyAddedNike();
            _SportLandCartPage.RemoveNike();
            _SportLandCartPage.VerifyRemovedNike();
        }
        [Test, Order(10)]
        public static void CouponField()
        {
            _SportLandCartPage.OpenCouponText();
            _SportLandCartPage.TypeWrongCouponCode("asasasa");
            _SportLandCartPage.SubmitWrongCouponeCode();
            _SportLandCartPage.VerifyWrongTypedCouponeCode();
        }
        [Test,Order(11)]
        public static void SelectCheckout()
        {
            _SportLandCartPage.ClickOnCheckout();
            _CheckoutPage.VerifyClickOnCheckout();
        }
        [Test,Order(12)]
        public static void VerifyYourOrder()
        {
            _CheckoutPage.VerifyYourOrder();
        }
    }
}
