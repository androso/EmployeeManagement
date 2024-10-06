using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class PositionService
    {
        private PositionRepository _positionRepository;

        public PositionService()
        {
            _positionRepository = new PositionRepository();
        }

        public List<Position> GetAllPositions()
        {
            return _positionRepository.GetPositions();
        }

        public void AddPosition(Position position)
        {
            _positionRepository.AddPosition(position);
        }

        public void UpdatePosition(Position position)
        {
            _positionRepository.EditPosition(position);
        }

        public void DeletePosition(int id)
        {
            _positionRepository.DeletePosition(id);
        }
    }
}