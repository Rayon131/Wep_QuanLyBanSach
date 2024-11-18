using System;
using System.Collections.Generic;

namespace AppData;
public class Account
{
    public int AccountId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public int? NhanVienId { get; set; }
    public NhanVien NhanVien { get; set; }
}

