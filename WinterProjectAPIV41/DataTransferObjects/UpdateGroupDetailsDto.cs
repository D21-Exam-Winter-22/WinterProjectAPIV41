namespace WinterProjectAPIV41.DataTransferObjects
{
    public class UpdateGroupDetailsDto
    {
        public int? GroupID { get; set; }
        public string? NewGroupName { get; set; }
        public string? NewGroupDescription { get; set; }
    }
}
