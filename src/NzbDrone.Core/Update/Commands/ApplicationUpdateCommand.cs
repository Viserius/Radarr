using NzbDrone.Core.Messaging.Commands;

namespace NzbDrone.Core.Update.Commands
{
    public class ApplicationUpdateCommand : Command
    {
        public override bool SendUpdatesToClient => true;
        public override bool RequiresDiskAccess => true;

        public override string CompletionMessage => "Restarting Radarr to apply updates";
    }
}
