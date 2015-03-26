using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForms_BlackJackDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnHit_Click(object sender, EventArgs e)
    {
        Random RNG = new Random();
        int Card = RNG.Next(10);
        if (Card == 0)
        {
            DealerCard1.ImageUrl = "/Images/PlayingCards/Cards/AceOfSpades.jpg";
        }
        if (Card == 1)
        {
            DealerCard1.ImageUrl = "/Images/PlayingCards/Cards/2OfClubs.jpg";
        }
        if (Card == 2)
        {
            DealerCard1.ImageUrl = "/Images/PlayingCards/Cards/3OfDiamonds.jpg";
        }
        if (Card == 3)
        {
            DealerCard1.ImageUrl = "/Images/PlayingCards/Cards/4OfHearts.jpg";
        }
        if (Card == 4)
        {
            DealerCard1.ImageUrl = "/Images/PlayingCards/Cards/5OfClubs.jpg";
        }
        if (Card == 5)
        {
            DealerCard1.ImageUrl = "/Images/6OfHearts.jpg";
        }
        if (Card == 6)
        {
            DealerCard1.ImageUrl = "/Images/7OfDiamonds.jpg";
        }
        if (Card == 7)
        {
            DealerCard1.ImageUrl = "/Images/PlayingCards/Cards/8ofhearts.jpg";
        }
        if (Card == 8)
        {
            DealerCard1.ImageUrl = "/Images/PlayingCards/Cards/9ofclubs.jpg";
        }
        if (Card == 9)
        {
            DealerCard1.ImageUrl = "/Images/PlayingCards/Cards/jackspade1.jpg";
        }
        
            
    }
    protected void btnStand_Click(object sender, EventArgs e)
    {

    }
}