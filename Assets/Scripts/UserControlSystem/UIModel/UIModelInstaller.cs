using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UIModelInstaller : MonoInstaller
{
	[SerializeField] private AssetContext _legacyContext;

	public override void InstallBindings()
	{
		Container.Bind<AssetContext>().FromInstance(_legacyContext);

		Container.Bind<CommandCreatorBase<IProduceUnitCommand>>().To<ProduceUnitCommandCommandCreator>().AsTransient();
		//Container.Bind<CommandCreatorBase<IAttackCommand>>().To<AttackCommandCommandCreator>().AsTransient();
		//Container.Bind<CommandCreatorBase<IMoveCommand>>().To<MoveCommandCommandCreator>().AsTransient();
		//Container.Bind<CommandCreatorBase<IPatrolCommand>>().To<PatrolCommandCommandCreator>().AsTransient();
		//Container.Bind<CommandCreatorBase<IStopCommand>>().To<StopCommandCommandCreator>().AsTransient();

		Container.Bind<CommandButtonsModel>().AsTransient();
	}
}
