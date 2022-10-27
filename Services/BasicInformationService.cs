using appPrevencionRiesgos.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using appPrevencionRiesgos.Model.Security;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace appPrevencionRiesgos.Services;

public class BasicInformationService: IBasicInformationService
{

    private readonly IMongoCollection<BasicInformationModel> _informationCollection;
    //private UserManager<IdentityUser> userManager;

    public BasicInformationService(IOptions<MongoDBSettings> mongoDBSettings)
    {
        var client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        var database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        _informationCollection = database.GetCollection<BasicInformationModel>(mongoDBSettings.Value.CollectionName);
    }
    public async Task<List<BasicInformationModel>> GetAllBasicInformationAsync() => await _informationCollection.Find(_ => true).ToListAsync();

    public async Task<BasicInformationModel?> GetOneBasicInformationAsync(int id) => await _informationCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateBasicInformationAsync(BasicInformationModel basicInformation) => await _informationCollection.InsertOneAsync(basicInformation);

    public async Task UpdateBasicInformationAsync(int id, BasicInformationModel basicInformation) => await _informationCollection.ReplaceOneAsync(x => x.Id == id, basicInformation);

    public async Task DeleteBasicInformationAsync(int id) => await _informationCollection.DeleteOneAsync(x => x.Id == id);
}