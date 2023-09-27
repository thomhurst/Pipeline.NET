namespace ModularPipelines.AWS;

internal class Amazon : IAmazon
{
    public Amazon(IAmazonProvisioner provisioner)
    {
        Provisioner = provisioner;
    }

    public IAmazonProvisioner Provisioner { get; }
}