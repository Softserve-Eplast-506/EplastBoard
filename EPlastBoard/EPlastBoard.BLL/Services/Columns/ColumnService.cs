﻿using EPlastBoard.BLL.Interfaces.Columns;
using EPlastBoard.DAL.Entities;
using EPlastBoard.DAL.Repositories.Interfaces;

namespace EPlastBoard.BLL.Services.Columns
{
    public class ColumnService: IColumnService
    {
        private readonly IRepositoryWrapper _repoWrapper;

        public ColumnService(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        public async Task<Column> GetColumnByIdAsync(int id)
        {
            return await _repoWrapper.Columns.GetFirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> EditColumnNameAsync(Column column)
        {
            _repoWrapper.Columns.Attach(column);
            _repoWrapper.Columns.Update(column);
            await _repoWrapper.SaveAsync();

            return column.Id;
        }

        /*public async Task<int> CreateColumnAsync(Column column)
        {

        }

        public async Task<Column> DeleteColumnAsync(int id)
        {

        }*/
    }
}