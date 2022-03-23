using System.Collections.Generic;
using ArrearsRules.V1.Domain;

namespace ArrearsRules.V1.Gateways
{
    public interface IExampleGateway
    {
        Entity GetEntityById(int id);

        List<Entity> GetAll();
    }
}
