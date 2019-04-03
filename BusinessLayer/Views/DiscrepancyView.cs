using BusinessLayer.Dictionaties;

namespace BusinessLayer.Views
{
    public class DiscrepancyView : BaseView
    {
        public int FlightID { get; set; }

        public bool FilledBy { get; set; }

        public string Description { get; set; }

        public string PilotRemarks { get; set; }

        public int? ATAChapterID { get; set; }

        public int DirectiveId { get; set; }

        public int? Num { get; set; }

        public DeffeсtPhase DeffeсtPhase { get; set; }

        public DeffeсtCategory DeffeсtCategory { get; set; }

        public DeffectConfirm DeffectConfirm { get; set; }

        public ActionType ActionType { get; set; }

        public ConsequenceFaults ConsequenceFault { get; set; }

        public ConsequenceOPS ConsequenceOps { get; set; }

        public int TimeDelay { get; set; }

        public IncidentType ConsequenceType { get; set; }

        public InterruptionType InterruptionType { get; set; }

        public OccurrenceType Occurrence { get; set; }

        public int? AuthId { get; set; }

        public int BaseComponentId { get; set; }

        public bool IsOccurrence { get; set; }

        public bool Substruction { get; set; }

        public bool EngineShutUp { get; set; }

        public string Remarks { get; set; }

        public string EngineRemarks { get; set; }

        public string Messages { get; set; }

        public string FDR { get; set; }

        public int? WorkPackageId { get; set; }

        public CorrectiveActionStatus Status { get; set; }

        public bool IsReliability { get; set; }


        public ATAChapterView ATAChapter { get; set; }

        public SpecialistView Auth { get; set; }

        public CorrectiveActionView CorrectiveAction { get; set; }
    }
}