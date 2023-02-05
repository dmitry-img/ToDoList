using Application.Contracts.Persistence;
using Application.Exceptions;
using Application.Features.ToDoList.Requests.Commands;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ToDoList.Handlers.Commands
{
    public class UpdateToDoListCommandHandler : IRequestHandler<UpdateToDoListCommand, Unit>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public UpdateToDoListCommandHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateToDoListCommand request, CancellationToken cancellationToken)
        {
            var toDoListEntity = await _toDoListRepository.GetAsync(request.UpdateToDoListDto.Id);

            if (toDoListEntity == null)
                throw new NotFoundException(nameof(toDoListEntity), request.UpdateToDoListDto.Id);

            _mapper.Map(request.UpdateToDoListDto, toDoListEntity);

            await _toDoListRepository.UpdateAsync(toDoListEntity);
            return Unit.Value;
        }
    }
}
