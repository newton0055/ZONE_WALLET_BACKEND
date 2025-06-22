using System;
using System.ComponentModel.DataAnnotations;

namespace zone_wallet_backend.Models;

public class Wallet
{
    [Key]

    public Guid Id { get; set; }

    public string UserId { get; set; }

    public string Address { get; set; }

    public string PrivateKey { get; set; }

    public string? WalletName { get; set; }

    public DateTime CreatedAt { get; set; }


}
