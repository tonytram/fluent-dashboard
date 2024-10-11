﻿using FluentDashboard.Application.TodoItems.Commands.CreateTodoItem;
using FluentDashboard.Application.TodoItems.Commands.DeleteTodoItem;
using FluentDashboard.Application.TodoLists.Commands.CreateTodoList;
using FluentDashboard.Domain.Entities;

using static FluentDashboard.Application.FunctionalTests.Testing;

namespace FluentDashboard.Application.FunctionalTests.TodoItems.Commands;
public class DeleteTodoItemTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoItemId()
    {
        var command = new DeleteTodoItemCommand(99);

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoItem()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateTodoItemCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        await SendAsync(new DeleteTodoItemCommand(itemId));

        var item = await FindAsync<TodoItem>(itemId);

        item.Should().BeNull();
    }
}
