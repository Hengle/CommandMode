using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 命令收集者
/// </summary>
public class CommandManager 
{
    /// 命令集
	private List<BaseCommand> CommandSet;

    public CommandManager()
    {
        CommandSet = new List<BaseCommand>();
    }

    /// <summary>
    /// 执行新的命令
    /// </summary>
    public void ExecutiveCommand(BaseCommand command)
    {
        CommandSet.Add(command);
        command.ExecuteCommand();

        Debug.Log("执行命令：" + command.CommandDescribe);
    }

    /// <summary>
    /// 撤销上一个命令
    /// </summary>
    public void RevocationCommand()
    {
        if (CommandSet.Count > 0)
        {
            BaseCommand command = CommandSet[CommandSet.Count - 1];
            CommandSet.Remove(command);
            command.RevocationCommand();
            
            Debug.Log("撤销命令：" + command.CommandDescribe);
        }
    }
}
