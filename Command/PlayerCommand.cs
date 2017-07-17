using UnityEngine;
/// <summary>
/// Player操作的命令
/// </summary>
public class PlayerCommand : BaseCommand
{
    #region 命令操作、撤销所涉及到的属性
    //目标
    private Player _commandTarget;
    //目标的位置
    private Vector3 _commandPosition;
    #endregion

    public PlayerCommand(Player commandTarget, Vector3 commandPosition, string commandDescribe)
    {
        _commandTarget = commandTarget;
        _commandPosition = commandPosition;
        CommandDescribe = commandDescribe;
    }

    /// <summary>
    /// 执行命令
    /// </summary>
    public override void ExecuteCommand()
    {
        base.ExecuteCommand();

        _commandTarget.transform.position = _commandPosition;
    }

    /// <summary>
    /// 撤销命令
    /// </summary>
    public override void RevocationCommand()
    {
        base.RevocationCommand();

        _commandTarget.transform.position = _commandPosition;
    }
}
