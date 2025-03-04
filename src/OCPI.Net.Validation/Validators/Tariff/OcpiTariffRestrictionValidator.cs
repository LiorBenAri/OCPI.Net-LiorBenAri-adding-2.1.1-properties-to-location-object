﻿using FluentValidation;
using OCPI.Validation;

namespace OCPI.Contracts;

internal class OcpiTariffRestrictionValidator : OcpiValidator<OcpiTariffRestrictions>
{
    public OcpiTariffRestrictionValidator(ActionType actionType, OcpiVersion ocpiVersion) : base(actionType, ocpiVersion)
    {
        JsonRuleFor(x => x.StartTime)
            .MaximumLength(5);

        JsonRuleFor(x => x.EndTime)
            .MaximumLength(5);

        JsonRuleFor(x => x.StartDate)
            .MaximumLength(10);

        JsonRuleFor(x => x.EndDate)
            .MaximumLength(10);

        RuleForEach(x => x.DayOfWeek)
            .IsInEnum();

        JsonRuleFor(x => x.Reservation)
            .IsInEnum();
    }
}
