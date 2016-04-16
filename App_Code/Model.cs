﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class CardInfo
{
    public int CardInfoId { get; set; }
    public Nullable<int> PokerOrder { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
}

public partial class Hand
{
    public int GameId { get; set; }
    public int UserId { get; set; }
    public int CardId { get; set; }

    public virtual User User { get; set; }
}

public partial class User
{
    public User()
    {
        this.Hands = new HashSet<Hand>();
    }

    public int UserId { get; set; }
    public string SessionId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public virtual ICollection<Hand> Hands { get; set; }
}
