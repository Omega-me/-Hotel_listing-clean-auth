/// <summary>
///     This file is autogenerated by toolkit, next time you generate files again it wil be regenerated
///     If you want to do something custom with this class use partial instead
/// </summary>

namespace Hotel_listing.Application.Contracts.RepositoryManager.Query;
public partial interface IQuery : IDisposable
{
    ICountryQuery Country { get; }
    IHotelQuery Hotel { get; }
    Task Save();
}