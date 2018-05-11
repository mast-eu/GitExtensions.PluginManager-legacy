﻿using Neptuo;
using Neptuo.Observables.Commands;
using PackageManager.Models;
using PackageManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PackageManager.ViewModels.Commands
{
    public class InstallCommand : AsyncCommand<IPackage>
    {
        private readonly IInstallService service;

        public InstallCommand(IInstallService service)
        {
            Ensure.NotNull(service, "service");
            this.service = service;
        }

        protected override bool CanExecuteOverride(IPackage package)
            => package != null && !service.IsInstalled(package);

        protected override Task ExecuteAsync(IPackage package, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public new void RaiseCanExecuteChanged()
            => base.RaiseCanExecuteChanged();
    }
}
