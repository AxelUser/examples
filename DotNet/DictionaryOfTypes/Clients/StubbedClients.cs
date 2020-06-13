using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DictionaryOfTypes.Clients
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class RestClientAttribute : Attribute
    {
    }

    public class Resource0
    {
        public Guid Id { get; }
    }
    
    public interface IResource0Client
    {
        Task<IReadOnlyCollection<Resource0>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource0> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource0> AddAsync(Resource0 resource, CancellationToken cancellationToken);
        Task<Resource0> UpdateAsync(Resource0 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource0Client: IResource0Client
    {
        private readonly HttpClient _client;

        public Resource0Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource0>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource0>>(Array.Empty<Resource0>());
        public Task<Resource0> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource0());
        public Task<Resource0> AddAsync(Resource0 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource0> UpdateAsync(Resource0 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource1
    {
        public Guid Id { get; }
    }
    
    public interface IResource1Client
    {
        Task<IReadOnlyCollection<Resource1>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource1> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource1> AddAsync(Resource1 resource, CancellationToken cancellationToken);
        Task<Resource1> UpdateAsync(Resource1 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource1Client: IResource1Client
    {
        private readonly HttpClient _client;

        public Resource1Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource1>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource1>>(Array.Empty<Resource1>());
        public Task<Resource1> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource1());
        public Task<Resource1> AddAsync(Resource1 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource1> UpdateAsync(Resource1 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource2
    {
        public Guid Id { get; }
    }
    
    public interface IResource2Client
    {
        Task<IReadOnlyCollection<Resource2>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource2> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource2> AddAsync(Resource2 resource, CancellationToken cancellationToken);
        Task<Resource2> UpdateAsync(Resource2 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource2Client: IResource2Client
    {
        private readonly HttpClient _client;

        public Resource2Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource2>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource2>>(Array.Empty<Resource2>());
        public Task<Resource2> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource2());
        public Task<Resource2> AddAsync(Resource2 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource2> UpdateAsync(Resource2 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource3
    {
        public Guid Id { get; }
    }
    
    public interface IResource3Client
    {
        Task<IReadOnlyCollection<Resource3>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource3> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource3> AddAsync(Resource3 resource, CancellationToken cancellationToken);
        Task<Resource3> UpdateAsync(Resource3 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource3Client: IResource3Client
    {
        private readonly HttpClient _client;

        public Resource3Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource3>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource3>>(Array.Empty<Resource3>());
        public Task<Resource3> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource3());
        public Task<Resource3> AddAsync(Resource3 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource3> UpdateAsync(Resource3 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource4
    {
        public Guid Id { get; }
    }
    
    public interface IResource4Client
    {
        Task<IReadOnlyCollection<Resource4>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource4> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource4> AddAsync(Resource4 resource, CancellationToken cancellationToken);
        Task<Resource4> UpdateAsync(Resource4 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource4Client: IResource4Client
    {
        private readonly HttpClient _client;

        public Resource4Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource4>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource4>>(Array.Empty<Resource4>());
        public Task<Resource4> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource4());
        public Task<Resource4> AddAsync(Resource4 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource4> UpdateAsync(Resource4 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource5
    {
        public Guid Id { get; }
    }
    
    public interface IResource5Client
    {
        Task<IReadOnlyCollection<Resource5>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource5> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource5> AddAsync(Resource5 resource, CancellationToken cancellationToken);
        Task<Resource5> UpdateAsync(Resource5 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource5Client: IResource5Client
    {
        private readonly HttpClient _client;

        public Resource5Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource5>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource5>>(Array.Empty<Resource5>());
        public Task<Resource5> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource5());
        public Task<Resource5> AddAsync(Resource5 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource5> UpdateAsync(Resource5 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource6
    {
        public Guid Id { get; }
    }
    
    public interface IResource6Client
    {
        Task<IReadOnlyCollection<Resource6>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource6> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource6> AddAsync(Resource6 resource, CancellationToken cancellationToken);
        Task<Resource6> UpdateAsync(Resource6 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource6Client: IResource6Client
    {
        private readonly HttpClient _client;

        public Resource6Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource6>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource6>>(Array.Empty<Resource6>());
        public Task<Resource6> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource6());
        public Task<Resource6> AddAsync(Resource6 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource6> UpdateAsync(Resource6 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource7
    {
        public Guid Id { get; }
    }
    
    public interface IResource7Client
    {
        Task<IReadOnlyCollection<Resource7>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource7> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource7> AddAsync(Resource7 resource, CancellationToken cancellationToken);
        Task<Resource7> UpdateAsync(Resource7 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource7Client: IResource7Client
    {
        private readonly HttpClient _client;

        public Resource7Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource7>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource7>>(Array.Empty<Resource7>());
        public Task<Resource7> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource7());
        public Task<Resource7> AddAsync(Resource7 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource7> UpdateAsync(Resource7 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource8
    {
        public Guid Id { get; }
    }
    
    public interface IResource8Client
    {
        Task<IReadOnlyCollection<Resource8>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource8> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource8> AddAsync(Resource8 resource, CancellationToken cancellationToken);
        Task<Resource8> UpdateAsync(Resource8 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource8Client: IResource8Client
    {
        private readonly HttpClient _client;

        public Resource8Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource8>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource8>>(Array.Empty<Resource8>());
        public Task<Resource8> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource8());
        public Task<Resource8> AddAsync(Resource8 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource8> UpdateAsync(Resource8 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource9
    {
        public Guid Id { get; }
    }
    
    public interface IResource9Client
    {
        Task<IReadOnlyCollection<Resource9>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource9> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource9> AddAsync(Resource9 resource, CancellationToken cancellationToken);
        Task<Resource9> UpdateAsync(Resource9 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource9Client: IResource9Client
    {
        private readonly HttpClient _client;

        public Resource9Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource9>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource9>>(Array.Empty<Resource9>());
        public Task<Resource9> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource9());
        public Task<Resource9> AddAsync(Resource9 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource9> UpdateAsync(Resource9 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource10
    {
        public Guid Id { get; }
    }
    
    public interface IResource10Client
    {
        Task<IReadOnlyCollection<Resource10>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource10> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource10> AddAsync(Resource10 resource, CancellationToken cancellationToken);
        Task<Resource10> UpdateAsync(Resource10 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource10Client: IResource10Client
    {
        private readonly HttpClient _client;

        public Resource10Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource10>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource10>>(Array.Empty<Resource10>());
        public Task<Resource10> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource10());
        public Task<Resource10> AddAsync(Resource10 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource10> UpdateAsync(Resource10 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource11
    {
        public Guid Id { get; }
    }
    
    public interface IResource11Client
    {
        Task<IReadOnlyCollection<Resource11>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource11> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource11> AddAsync(Resource11 resource, CancellationToken cancellationToken);
        Task<Resource11> UpdateAsync(Resource11 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource11Client: IResource11Client
    {
        private readonly HttpClient _client;

        public Resource11Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource11>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource11>>(Array.Empty<Resource11>());
        public Task<Resource11> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource11());
        public Task<Resource11> AddAsync(Resource11 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource11> UpdateAsync(Resource11 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource12
    {
        public Guid Id { get; }
    }
    
    public interface IResource12Client
    {
        Task<IReadOnlyCollection<Resource12>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource12> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource12> AddAsync(Resource12 resource, CancellationToken cancellationToken);
        Task<Resource12> UpdateAsync(Resource12 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource12Client: IResource12Client
    {
        private readonly HttpClient _client;

        public Resource12Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource12>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource12>>(Array.Empty<Resource12>());
        public Task<Resource12> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource12());
        public Task<Resource12> AddAsync(Resource12 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource12> UpdateAsync(Resource12 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource13
    {
        public Guid Id { get; }
    }
    
    public interface IResource13Client
    {
        Task<IReadOnlyCollection<Resource13>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource13> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource13> AddAsync(Resource13 resource, CancellationToken cancellationToken);
        Task<Resource13> UpdateAsync(Resource13 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource13Client: IResource13Client
    {
        private readonly HttpClient _client;

        public Resource13Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource13>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource13>>(Array.Empty<Resource13>());
        public Task<Resource13> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource13());
        public Task<Resource13> AddAsync(Resource13 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource13> UpdateAsync(Resource13 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource14
    {
        public Guid Id { get; }
    }
    
    public interface IResource14Client
    {
        Task<IReadOnlyCollection<Resource14>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource14> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource14> AddAsync(Resource14 resource, CancellationToken cancellationToken);
        Task<Resource14> UpdateAsync(Resource14 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource14Client: IResource14Client
    {
        private readonly HttpClient _client;

        public Resource14Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource14>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource14>>(Array.Empty<Resource14>());
        public Task<Resource14> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource14());
        public Task<Resource14> AddAsync(Resource14 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource14> UpdateAsync(Resource14 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource15
    {
        public Guid Id { get; }
    }
    
    public interface IResource15Client
    {
        Task<IReadOnlyCollection<Resource15>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource15> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource15> AddAsync(Resource15 resource, CancellationToken cancellationToken);
        Task<Resource15> UpdateAsync(Resource15 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource15Client: IResource15Client
    {
        private readonly HttpClient _client;

        public Resource15Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource15>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource15>>(Array.Empty<Resource15>());
        public Task<Resource15> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource15());
        public Task<Resource15> AddAsync(Resource15 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource15> UpdateAsync(Resource15 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource16
    {
        public Guid Id { get; }
    }
    
    public interface IResource16Client
    {
        Task<IReadOnlyCollection<Resource16>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource16> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource16> AddAsync(Resource16 resource, CancellationToken cancellationToken);
        Task<Resource16> UpdateAsync(Resource16 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource16Client: IResource16Client
    {
        private readonly HttpClient _client;

        public Resource16Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource16>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource16>>(Array.Empty<Resource16>());
        public Task<Resource16> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource16());
        public Task<Resource16> AddAsync(Resource16 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource16> UpdateAsync(Resource16 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource17
    {
        public Guid Id { get; }
    }
    
    public interface IResource17Client
    {
        Task<IReadOnlyCollection<Resource17>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource17> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource17> AddAsync(Resource17 resource, CancellationToken cancellationToken);
        Task<Resource17> UpdateAsync(Resource17 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource17Client: IResource17Client
    {
        private readonly HttpClient _client;

        public Resource17Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource17>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource17>>(Array.Empty<Resource17>());
        public Task<Resource17> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource17());
        public Task<Resource17> AddAsync(Resource17 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource17> UpdateAsync(Resource17 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource18
    {
        public Guid Id { get; }
    }
    
    public interface IResource18Client
    {
        Task<IReadOnlyCollection<Resource18>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource18> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource18> AddAsync(Resource18 resource, CancellationToken cancellationToken);
        Task<Resource18> UpdateAsync(Resource18 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource18Client: IResource18Client
    {
        private readonly HttpClient _client;

        public Resource18Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource18>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource18>>(Array.Empty<Resource18>());
        public Task<Resource18> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource18());
        public Task<Resource18> AddAsync(Resource18 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource18> UpdateAsync(Resource18 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

    public class Resource19
    {
        public Guid Id { get; }
    }
    
    public interface IResource19Client
    {
        Task<IReadOnlyCollection<Resource19>> GetAllAsync(CancellationToken cancellationToken);
        Task<Resource19> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<Resource19> AddAsync(Resource19 resource, CancellationToken cancellationToken);
        Task<Resource19> UpdateAsync(Resource19 resource, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }

    [RestClientAttribute]
    public class Resource19Client: IResource19Client
    {
        private readonly HttpClient _client;

        public Resource19Client(HttpClient client)
        {
            _client = client;
        }
        
        public Task<IReadOnlyCollection<Resource19>> GetAllAsync(CancellationToken cancellationToken) => Task.FromResult<IReadOnlyCollection<Resource19>>(Array.Empty<Resource19>());
        public Task<Resource19> GetAsync(Guid id, CancellationToken cancellationToken) => Task.FromResult(new Resource19());
        public Task<Resource19> AddAsync(Resource19 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task<Resource19> UpdateAsync(Resource19 resource, CancellationToken cancellationToken) => Task.FromResult(resource);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken) => Task.CompletedTask;
    }

}
