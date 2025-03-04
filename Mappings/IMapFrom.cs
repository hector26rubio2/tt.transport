
namespace Transport.Mappings
{
    using AutoMapper;
    public interface IMapFrom<T>
    {
   
        void MappingFrom(Profile profile) =>
            profile.CreateMap(typeof(T), GetType());


        void MappingTo(Profile profile) =>
            profile.CreateMap(GetType(), typeof(T));
    }
}
