using UnityEngine.UI;
/// <summary>
/// InputField操作的命令
/// </summary>
public class InputFieldCommand : BaseCommand
{
    #region 命令操作、撤销所涉及到的属性
    //目标
    private InputField _commandTarget;
    //目标的值
    private string _commandValue;
    #endregion

    public InputFieldCommand(InputField commandTarget, string commandValue, string commandDescribe)
    {
        _commandTarget = commandTarget;
        _commandValue = commandValue;
        CommandDescribe = commandDescribe;
    }

    /// <summary>
    /// 执行命令
    /// </summary>
    public override void ExecuteCommand()
    {
        base.ExecuteCommand();

        _commandTarget.text = _commandValue;
    }

    /// <summary>
    /// 撤销命令
    /// </summary>
    public override void RevocationCommand()
    {
        base.RevocationCommand();

        _commandTarget.text = _commandValue;
    }
}
