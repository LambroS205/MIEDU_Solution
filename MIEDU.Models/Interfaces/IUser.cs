using System;

namespace MIEDU.Models.Interfaces
{
    // TÍNH TRỪU TƯỢNG (ABSTRACTION): Interface chỉ định nghĩa hành vi, không cài đặt chi tiết.
    public interface IUser
    {
        string Username { get; }
        string GetRoleName();
        bool Authenticate(string password);
    }
}